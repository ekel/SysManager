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
        }

        private void btnDtl_Click(object sender, EventArgs e)
        {
            base.OperType = OperateType.Detail;
            base.SwitchAdministration();
            InitData();
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
					getGrantFromTreeView();
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
            
            base.SwitchAdministration();

            InitData();
            
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
            InitData();
        }

        private bool AddData()
        {
            
            GetDataFromForm();
            try
            {
                rhdbs.user_info.Adduser_infoRow(sUser, sPswd, sRole, sNote);
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

        private bool UptData()
        {
            GetDataFromForm();
            try
            {
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index].BeginEdit();
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["user_id"] = sUser;
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["pwd"] = sPswd;
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["role"] = sRole;
                rhdbs.user_info.Rows[dataGridView.CurrentRow.Index]["note"] = sNote;
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


        private bool InitData()
        {
            if (!GetDataFromDataTable())
                return false;

            SetValueToForm();

            return true;
        }
        private void GetDataFromForm()
        {
            sUser = txtUser.Text.Trim();
            sPswd = txtPwd.Text.Trim();
            sNote = txtNote.Text.Trim();
            //if (radioBtn1.Checked)
            //    sRole = "0";
            //else
            //    sRole = "1";

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

        private void SetValueToForm()
        {
            txtUser.Text = sUser;
            txtPwd.Text = sPswd;
            if (string.Compare(sRole, "0") == 0)
            {
                //radioBtn1.Checked = true;
            }
            else
                //radioBtn2.Checked = true;
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

		private void getGrantFromTreeView()
		{

			TreeNodeCollection nodes = treeViewRole.Nodes;

			foreach (TreeNode childNode in nodes)
			{
				
				setGrantValue(childNode);
				
			}
		}
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
						MenuSet.remindSel = 1;
					else
						MenuSet.remindSel = 0;
					
				}
				else if (treeNode.Name == "remindAdd")
				{

				}
				else if (treeNode.Name == "remindUpt")
				{

				}
				else if (treeNode.Name == "remindDel")
				{

				}
				else if (treeNode.Name == "custSel")
				{

				}
				else if (treeNode.Name == "custAdd")
				{

				}
				else if (treeNode.Name == "custUpt")
				{

				}
				else if (treeNode.Name == "custDel")
				{

				}
				else if (treeNode.Name == "userSel")
				{

				}
				else if (treeNode.Name == "userAdd")
				{

				}
				else if (treeNode.Name == "userUpt")
				{

				}
				else if (treeNode.Name == "userDel")
				{

				}
				else if (treeNode.Name == "pwdSet")
				{

				}
				else if (treeNode.Name == "logSel")
				{

				}
				
			}
		}


    }
}
