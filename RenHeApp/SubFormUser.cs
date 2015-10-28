using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace RenHeApp
{
    public partial class SubFormUser : SubFormBase
    {
        private Token TheToken;
        private MySqlDataAdapter dataAdapter;
        private string sUser;
        private string sPswd;
        private string sRole;
        private string sNote;
		//private string[] strMenuSet=new string[800];
		private string sMenuSet;
		//private byte[] arrMenuSet;
		private char[] chrMenuSet;
		private const int MENU_NUM = 30;

        public SubFormUser(Token tk)
        {
            InitializeComponent();
            TheToken = tk;

            try
            {
                string strSel = "SELECT * FROM rhdbs.user_info";
                if (TheToken.DataConn.State == ConnectionState.Closed)
                {
                    TheToken.DataConn.Open();
                }
                dataAdapter = new MySqlDataAdapter(strSel, TheToken.DataConn);
            }
            catch
            {
                MessageBox.Show("初始化失败！");
            }

			InitData();
			
        }

        private void btnDtl_Click(object sender, EventArgs e)
        {
            base.OperType = OperateType.Detail;
            base.SwitchAdministration();
            InitFormData();
        }

        private void SubFormUser_Load(object sender, EventArgs e)
        {
            base.Init();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (base.OperType)
            {
                case OperateType.Detail:
                    break;
                case OperateType.Insert:
					
                    AddData();
                    break;
                case OperateType.Delete:
                    if (MessageBox.Show("确定要删除该客户吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (DelData() == false)
                        {
                            MessageBox.Show("删除客户失败！");
                            return;
                        }
                    }
                    break;
                case OperateType.Update:
                    UptData();
                    break;
                default:
                    break;
            }
            BtnInit();
            ClearDataToForm();
            base.SwitchOverview();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.SwitchOverview();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            base.OperType = OperateType.Insert;
            base.SwitchAdministration();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            btnDtl.Enabled = true;
            if (TheToken.Role == 0)
            {
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
                btnUpt.Enabled = true;
            }

            try
            {
                //rhdbs.cust_info.Clear();
                dataAdapter.Fill(rhdbs.user_info);
            }
            catch
            {
                MessageBox.Show("查询用户信息失败！");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            base.OperType = OperateType.Delete;
            txtUser.ReadOnly = true;
            txtPwd.ReadOnly = true;
            txtNote.ReadOnly = true;
			dataGridView.ReadOnly = true;

            base.SwitchAdministration();

            InitFormData();
            
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpt_Click(object sender, EventArgs e)
        {
            base.OperType = OperateType.Update;
            txtUser.ReadOnly = true;
            base.SwitchAdministration();
            InitFormData();
        }

		// 添加一条记录
        private bool AddData()
        {
			getGrantFromTreeView();

            SetFieldsValue();
            try
            {
				rhdbs.user_info.Adduser_infoRow(sUser, sPswd, sRole, sNote, sMenuSet);

                MySqlCommandBuilder scb = new MySqlCommandBuilder(dataAdapter);
                scb.ReturnGeneratedIdentifiers = false;
                dataAdapter.Update(rhdbs.user_info.GetChanges());
                rhdbs.user_info.AcceptChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

		// 更新一条记录
        private bool UptData()
        {
			getGrantFromTreeView();
            SetFieldsValue();
            try
            {
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index].BeginEdit();
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["user_id"] = sUser;
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["pwd"] = sPswd;
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["role"] = sRole;
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["note"] = sNote;
				rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["menu_set"] = sMenuSet;
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index].EndEdit();
                MySqlCommandBuilder scb = new MySqlCommandBuilder(dataAdapter);
                scb.ReturnGeneratedIdentifiers = false;
                dataAdapter.Update(rhdbs.user_info.GetChanges());
                rhdbs.user_info.AcceptChanges();
            }
            catch
            {
                return false;
            }
            return true;
        }

		// 删除一条记录
        private bool DelData()
        {
            
            try
            {
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index].Delete();
                MySqlCommandBuilder scb = new MySqlCommandBuilder(dataAdapter);
                scb.ReturnGeneratedIdentifiers = false;
                dataAdapter.Update(rhdbs.user_info.GetChanges());
                rhdbs.user_info.AcceptChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }


        private bool InitFormData()
        {
            if (!GetDataFromDataTable())
                return false;

            SetFormValue();

            return true;
        }

		// 设置表字段值
        private void SetFieldsValue()
        {
            sUser = txtUser.Text.Trim();
            sPswd = txtPwd.Text.Trim();
            sNote = txtNote.Text.Trim();
            
			sMenuSet = new string(chrMenuSet);
			//string s;
			
        }
        private bool GetDataFromDataTable()
        {
            try
            {
                sUser = rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["user_id"].ToString();
                sPswd = rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["pwd"].ToString();
                sRole = rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["role"].ToString();
                sNote = rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["note"].ToString();
            }
            catch
            {
                return false;
            }

            return true;
        }

		// 给字段赋值
        private void SetFormValue()
        {
            txtUser.Text = sUser;
            txtPwd.Text = sPswd;
            
            txtNote.Text = sNote;

        }

        private void ClearDataToForm()
        {
            txtUser.Text = string.Empty;
            txtPwd.Text = string.Empty;
            txtNote.Text = string.Empty;
            //radioBtn2.Checked = true;
        }

        private void BtnInit()
        {
            txtUser.ReadOnly = false;
            txtPwd.ReadOnly = false;
            txtNote.ReadOnly = false;
        }


        private void txtUser_MouseLeave(object sender, EventArgs e)
        {
            labMsg.Text = string.Empty;
            if (txtUser.Text.Length > 30)
            {
                labMsg.Text = "长度超限";

            }
        }

		private void treeViewRole_AfterCheck(object sender, TreeViewEventArgs e)
		{
			if (e.Action != TreeViewAction.Unknown && e.Node.Nodes.Count > 0)
			{
				foreach (TreeNode childNode in e.Node.Nodes)
				{
					childNode.Checked = e.Node.Checked;
					if (childNode.Nodes.Count > 0)
					{
						foreach (TreeNode grandSonNode in childNode.Nodes)
						{
							grandSonNode.Checked = e.Node.Checked;
						}
					}
				}
			}			
		}

		// 从界面treeview中取到设置的权限值
		private void getGrantFromTreeView()
		{

			TreeNodeCollection nodes = treeViewRole.Nodes;

			foreach (TreeNode childNode in nodes)
			{
				setGrantValue(childNode);
			}
		}

		//string arrMenuSet;
		// 设置用户操作权限位的值
		private void setGrantValue(TreeNode treeNode)
		{
			if (treeNode.Nodes.Count > 0)
			{
				foreach (TreeNode tn in treeNode.Nodes)
				{
					setGrantValue(tn);
				}
			}
			else
			{

				if (treeNode.Name == "remindSel")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.remindSel = 1;
						chrMenuSet[0] = '1';
					}
					else
					{
						MenuSet.remindSel = 0;
						//arrMenuSet[0] = 0;
						//sMenuSet += "0";
						chrMenuSet[0] = '0';
					}
					
				}
				else if (treeNode.Name == "remindAdd")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.remindAdd = 1;
						//arrMenuSet[1] = 1;
						chrMenuSet[1] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.remindAdd = 0;
						//arrMenuSet[1] = 0;
						chrMenuSet[1] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "remindUpt")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.remindUpt = 1;
						//arrMenuSet[2] = 1;
						chrMenuSet[2] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.remindUpt = 0;
						//arrMenuSet[2] = 0;
						chrMenuSet[2] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "remindDel")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.remindDel = 1;
						//arrMenuSet[3] = 1;
						chrMenuSet[3] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.remindDel = 0;
						//arrMenuSet[3] = 0;
						chrMenuSet[3] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "custSel")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.custSel = 1;
						//arrMenuSet[4] = 1;
						chrMenuSet[4] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.custSel = 0;
						//arrMenuSet[4] = 0;
						chrMenuSet[4] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "custAdd")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.custAdd = 1;
						//arrMenuSet[5] = 1;
						chrMenuSet[5] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.custAdd = 0;
						//arrMenuSet[5] = 0;
						chrMenuSet[5] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "custUpt")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.custUpt = 1;
						//arrMenuSet[6] = 1;
						chrMenuSet[6] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.custUpt = 0;
						//arrMenuSet[6] = 0;
						chrMenuSet[6] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "custDel")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.custDel = 1;
						//arrMenuSet[7] = 1;
						chrMenuSet[7] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.custDel = 0;
						//arrMenuSet[7] = 0;
						chrMenuSet[7] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "userSel")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.userSel = 1;
						//arrMenuSet[8] = 1;
						chrMenuSet[8] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.userSel = 0;
						//arrMenuSet[8] = 0;
						chrMenuSet[8] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "userAdd")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.userAdd = 1;
						//arrMenuSet[9] = 1;
						chrMenuSet[9] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.userAdd = 0;
						//arrMenuSet[9] = 0;
						chrMenuSet[9] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "userUpt")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.userUpt = 1;
						//arrMenuSet[10] = 1;
						chrMenuSet[10] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.userUpt = 0;
						//arrMenuSet[10] = 0;
						chrMenuSet[10] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "userDel")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.userDel = 1;
						//arrMenuSet[11] = 1;
						chrMenuSet[11] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.userDel = 0;
						//arrMenuSet[11] = 0;
						chrMenuSet[11] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "pwdSet")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.pwdSet = 1;
						//arrMenuSet[12] = 1;
						chrMenuSet[12] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.pwdSet = 0;
						//arrMenuSet[12] = 0;
						chrMenuSet[12] = '0';
						//sMenuSet += "0";
					}
				}
				else if (treeNode.Name == "logSel")
				{
					if (treeNode.Checked == true)
					{
						MenuSet.logSel = 1;
						//arrMenuSet[13] = 1;
						chrMenuSet[13] = '1';
						//sMenuSet += "1";
					}
					else
					{
						MenuSet.logSel = 0;
						//arrMenuSet[13] = 0;
						chrMenuSet[13] = '0';
						//sMenuSet += "0";
					}
				}	
			}
		}

		private void InitData()
		{
			chrMenuSet = new char[MENU_NUM];
			for (int i = 0; i < MENU_NUM; i++)
			{
				chrMenuSet[i] = '0';
			}
		}


    }
}
