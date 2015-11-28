using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;
using System.Threading;

namespace RenHeApp
{
    public partial class FormMain : Form
    {
		private string sMenuSet;
        public FormMain()
        {
            InitializeComponent();
			dataTab = new DataTable();
            #region
            this.FormBorderStyle = FormBorderStyle.None;
            this.MaximumSize = new Size(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            this.WindowState = FormWindowState.Maximized;
            #endregion
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string strServer;
			string strSql;
            try
            {
                XmlReaderSettings settings = new XmlReaderSettings();
                // 忽略xml的注释
                settings.IgnoreComments = true;
                XmlReader reader = XmlReader.Create(@".\config.xml", settings);
                XmlDocument profile = new XmlDocument();
                profile.Load(reader);
                XmlNode node = profile.SelectSingleNode("/config/server");
                strServer = node.InnerText;
            }
            catch
            {
                MessageBox.Show(this, "读取配置文件失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            try
            {
                DataConnStr = String.Format("server={0};user id={1};password={2};database={3}",
                                 strServer, "renhe", "renhe", "rhdbs");
                DataConn = new MySqlConnection(DataConnStr);
                DataConn.Open();
            }
            catch
            {
                MessageBox.Show(this, "连接数据库失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // 试用限制 截止到2015-12-1
            DateTime TermTime = new DateTime(2015, 12, 1);
            if ( DateTime.Now >= TermTime)
            {
                MessageBox.Show("试用时间结束，请联系厂家购买正版！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
                return;
            }

            FormLogin frmLogin = new FormLogin();
            frmLogin.ShowDialog();

            while (true)
            {
                if (frmLogin.DialogResult == DialogResult.OK)
                {
                    string sUser = frmLogin.User;
                    string sPswd = frmLogin.Password;

                    if (sUser == string.Empty)
                    {
                        MessageBox.Show("用户名不能为空!", "登录错误");
                        if (IsOverTimes())
                        {
                            this.Close();
                            break;
                        }
                        frmLogin.ShowDialog();
                        continue;
                    }

                    strSql = string.Format("select * from rhdbs.user_info where user_id='{0}' and pwd='{1}'",
                        sUser, sPswd);

                    try
                    {
                        MySqlDataAdapter tableAdapter = new MySqlDataAdapter(strSql, DataConn);
                        tableAdapter.Fill(dataTab);
                        // 取用户权限
                        //Int32 role = Convert.ToInt32(dataTab.Rows[0][2].ToString());
						sMenuSet = dataTab.Rows[0][4].ToString();

						// 权限解析
						RoleParse();
						//SetMenu();
                        // 获得登录令牌
                        TheToken = new Token(sUser, sPswd);
                        TheToken.DataConn = DataConn;
                        TheToken.DataConnStr = DataConnStr;

                        break;
                    }
                    catch
                    {
                        MessageBox.Show("错误的用户名或密码！请重新登录", "登录错误");
                        if (IsOverTimes())
                        {
                            this.Close();
                            break;
                        }
                        frmLogin.ShowDialog();
                        continue;
                    }


                }
                else if (frmLogin.DialogResult == DialogResult.Cancel)
                {
                    this.Close();
                    break;
                }
            }
            frmLogin.Close();

            // 生日提醒
            RemindBirth();
            // 提醒功能线程
            Thread RemindThread = new Thread(Remind_Loop);
            RemindThread.Priority = ThreadPriority.Highest;
            RemindThread.IsBackground = true;
            RemindThread.Start();
        }

		private bool IsOverTimes()
		{
			num++;
			if (num >= 10)
			{
				MessageBox.Show("您登陆错误次数已经超10次!\n应用即将退出", "Waring");
				return true;
			}
			return false;
		}
        // 添加子窗体
        private void AddSubForm(Form frm)
        {
            foreach (TabPage tp in tabMain.TabPages)
            {
                // 该子窗体已添加！
                if (tp.Text == frm.Text)
                {
                    return;
                }
            }

            frm.TopLevel = false;
            frm.ControlBox = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            TabPage tabPage = new TabPage(frm.Text);
            tabPage.Controls.Add(frm);
            tabMain.TabPages.Add(tabPage);
            tabMain.SelectedTab = tabPage;

            frm.Show();
        }

        private void btnCloseSubForm_Click(object sender, EventArgs e)
        {
            tabMain.TabPages.Remove(tabMain.SelectedTab);
        }

        private void 客户查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmCust == null)
            {
                FrmCust = new SubFormCust(TheToken);
                AddSubForm(FrmCust);
            }
            else
            {
                AddSubForm(FrmCust);
            }
        }

        private Token TheToken;

        private SubFormCust FrmCust;
        private SubFormRemind FrmRemind;
        private SubFormUser frmUser;
        private SubFormPwd frmPwd;
        //private RemindDialog DialogRemind;

        private MySqlConnection DataConn;
        private string DataConnStr;
		private DataTable dataTab;
		private static int num = 0;

        private void 管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmRemind == null)
            {
                FrmRemind = new SubFormRemind(TheToken);
                AddSubForm(FrmRemind);
            }
            else
            {
                AddSubForm(FrmRemind);
            }
        }

        private void RemindBirth()
        {
            rhdbs.birthRemindDataTable RemindTable = new rhdbs.birthRemindDataTable();

            // 查询列表
            string strSelLst = "cust_id,cust_name,phone,level,birthday";
            // 表列表
            string strTabLst = "rhdbs.cust_info";
            // 条件列表
            string strCodLst = "DATE_FORMAT(birthday,'%m-%d') = DATE_FORMAT(NOW(),'%m-%d')";
            // 排序列表
            string strOrdLst = "level,cust_id";
            string strSelSql = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3}",
                strSelLst, strTabLst, strCodLst, strOrdLst);

            try
            {
                MySqlConnection sqlConn = new MySqlConnection(TheToken.DataConnStr);
                sqlConn.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(strSelSql, sqlConn);
                RemindTable.Clear();
                sqlDataAdapter.Fill(RemindTable);

                if (RemindTable.Rows.Count > 0)
                {
                    RemindDialog2 diaRemind = new RemindDialog2(ref RemindTable);
                    diaRemind.ShowDialog();
                    if (diaRemind.DialogResult == DialogResult.Cancel)
                    {
                        MySqlCommandBuilder scb = new MySqlCommandBuilder(sqlDataAdapter);
                        scb.ReturnGeneratedIdentifiers = false;
                        sqlDataAdapter.Update(RemindTable);
                        RemindTable.AcceptChanges();
                    }
                }
                sqlConn.Close();
            }
            catch
            {
                MessageBox.Show("查询客户生日提醒信息出错！");
            }
        }

        private void Remind_Loop()
        {
            rhdbs.askRemindDataTable RemindTable = new rhdbs.askRemindDataTable();

            while (true)
            {
                // 查询列表
                string strSelLst = "cust_id,cust_name,phone,level,remind_flag";
                // 表列表
                string strTabLst = "rhdbs.cust_info";
                // 条件列表
                string strConLst = "remind_flag='是' AND remind_time <= NOW()";
                // 排序列表
                string strOrdLst = "level,cust_id";
                string strSelSql = string.Format("SELECT {0} FROM {1} WHERE {2} ORDER BY {3}",
                    strSelLst, strTabLst, strConLst, strOrdLst);

                try
                {
                    MySqlConnection sqlConn = new MySqlConnection(TheToken.DataConnStr);
                    sqlConn.Open();
                    MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(strSelSql, sqlConn);
                    RemindTable.Clear();
                    sqlDataAdapter.Fill(RemindTable);

                    if (RemindTable.Rows.Count > 0)
                    {
                        RemindDialog diaRemind = new RemindDialog(ref RemindTable);
                        diaRemind.ShowDialog();
                        if (diaRemind.DialogResult == DialogResult.Cancel)
                        {
                            MySqlCommandBuilder scb = new MySqlCommandBuilder(sqlDataAdapter);
                            scb.ReturnGeneratedIdentifiers = false;
                            sqlDataAdapter.Update(RemindTable);
                            RemindTable.AcceptChanges();
                        }
                    }
                    sqlConn.Close();
                }
                catch
                {
                    MessageBox.Show("查询客户咨询提醒信息出错！");
                }

                // 睡眠5分钟
                Thread.Sleep(5 * 60 * 1000);
            }
        }

        private void 员工资料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmUser == null)
            {
                frmUser = new SubFormUser(TheToken);
            }
            // 赋予子窗体数据连接
            //frmUser.DataConn = DataConn;
            AddSubForm(frmUser);
        }

        private void 操作日志查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmPwd == null)
            {
                frmPwd = new SubFormPwd(TheToken);
                AddSubForm(frmPwd);
            }
            else
            {
                AddSubForm(frmPwd);
            }
        }


        private void pictMinus_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void picPlus_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

		private void RoleParse()
		{
			MenuSet.remindSel = sMenuSet[0];
			MenuSet.remindAdd = sMenuSet[1];
			MenuSet.remindUpt = sMenuSet[2];
			MenuSet.remindDel = sMenuSet[3];
			MenuSet.custSel = sMenuSet[4];
			MenuSet.custAdd = sMenuSet[5];
			MenuSet.custUpt = sMenuSet[6];
			MenuSet.custDel = sMenuSet[7];
			MenuSet.userSel = sMenuSet[8];
			MenuSet.userAdd = sMenuSet[9];
			MenuSet.userUpt = sMenuSet[10];
			MenuSet.userDel = sMenuSet[11];
			MenuSet.pwdSet = sMenuSet[12];
			MenuSet.logSel = sMenuSet[13];
		}

        //private void SetMenu()
        //{
        //    if (MenuSet.pwdSet == '0')
        //        操作日志查询ToolStripMenuItem.Enabled = false;
        //    if (MenuSet.logSel == '0')
        //        this.登录日志查询ToolStripMenuItem.Enabled = false;
        //}
    }
}
