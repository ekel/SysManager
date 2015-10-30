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
    public partial class SubFormRemind : SubFormBase
    {
        public SubFormRemind(Token tk)
        {
            InitializeComponent();
            TheToken = tk;

            try
            {
                string strSql = "SELECT cust_id,cust_name,sex,birthday,level,remind_flag,remind_time,xczx,dhzx,tbtx,cjjl FROM rhdbs.cust_info";
                if (TheToken.DataConn.State == ConnectionState.Closed)
                {
                    TheToken.DataConn.Open();
                }
                dataAdapter = new MySqlDataAdapter(strSql, TheToken.DataConn);
            }
            catch
            {
                MessageBox.Show("初始化失败！");
            }

			// 菜单权限
			//if (MenuSet.remindSel == '1')
				btnSel.Enabled = true;
			//else
			//	btnSel.Enabled = false;

			//if (MenuSet.remindAdd == '1')
				btnAdd.Enabled = true;
			//else
			//	btnAdd.Enabled = false;

			//if (MenuSet.remindDel == '1')
				btnDel.Enabled = true;
			//else
			//	btnDel.Enabled = false;

			//if (MenuSet.remindUpt == '1')
				btnUpt.Enabled = true;
			//else
			//	btnUpt.Enabled = false;
        }

        private MySqlDataAdapter dataAdapter;
        private Token TheToken;

        private void SubFormCust_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            if (MenuSet.remindSel == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                btnDtl.Enabled = true;
                if (TheToken.Role == 0)
                {
                    //btnAdd.Enabled = true;
                    //btnDel.Enabled = true;
                    btnUpt.Enabled = true;
                }

                MySqlConnection conn = new MySqlConnection(TheToken.DataConnStr);
                conn.Open();
                string strSelName = txtSelName.Text.Trim();
                string strSelLevel = cmbSelLvl.Text.Trim();
                string strSelRmd = cmbSelRmd.Text.Trim();
                string strSel = string.Format("SELECT cust_id,cust_name,sex,birthday,level,remind_flag,remind_time,xczx,dhzx,tbtx,cjjl FROM rhdbs.cust_info WHERE (cust_name='{0}' OR '{0}'='') AND (level='{1}' OR '{1}'='') AND (remind_flag='{2}' OR '{2}'='')", strSelName, strSelLevel, strSelRmd);
                MySqlDataAdapter da = new MySqlDataAdapter(strSel, conn);
                rhdbs.remind.Clear();
                // rhdbs.remind.AcceptChanges();
                da.Fill(rhdbs.remind);
            }
            catch
            {
                MessageBox.Show("查询客户信息失败！");
            }
        }

        private void btnDtl_Click(object sender, EventArgs e)
        {
            if (MenuSet.remindSel == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OperType = OperateType.Detail;
            SwitchAdministration();
            SetEnabled(false);
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            if (MenuSet.remindUpt == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OperType = OperateType.Update;
            SwitchAdministration();
            SetEnabled(true);
        }

        private bool UpdateCustInfo()
        {
            try
            {
                rhdbs.remind.Rows[dataGridView.CurrentRow.Index].BeginEdit();
	            rhdbs.remind.Rows[dataGridView.CurrentRow.Index]["remind_flag"] = cmbRemind.Text;
	            rhdbs.remind.Rows[dataGridView.CurrentRow.Index]["remind_time"] = dateTimeRemind.Value;
	            rhdbs.remind.Rows[dataGridView.CurrentRow.Index]["xczx"] = txtXczx.Text;
	            rhdbs.remind.Rows[dataGridView.CurrentRow.Index]["dhzx"] = txtDhzx.Text;
	            rhdbs.remind.Rows[dataGridView.CurrentRow.Index]["tbtx"] = txtTbtx.Text;
	            rhdbs.remind.Rows[dataGridView.CurrentRow.Index]["cjjl"] = txtCjjl.Text;
                rhdbs.remind.Rows[dataGridView.CurrentRow.Index].EndEdit();
                MySqlCommandBuilder scb = new MySqlCommandBuilder(dataAdapter);
                //scb.ReturnGeneratedIdentifiers = false;
                dataAdapter.Update(rhdbs.remind.GetChanges());
                rhdbs.remind.AcceptChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            switch (OperType)
            {
                case OperateType.Detail:
                    // 啥也不做
                    break;
                case OperateType.Insert:
                    break;
                case OperateType.Delete:
                    break;
                case OperateType.Update:
                    if (UpdateCustInfo() == false)
                    {
                        SwitchOverview();
                        MessageBox.Show("修改客户失败！");
                        return;
                    }
                    break;
                default:
                    break;
            }
            SwitchOverview();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            SwitchOverview();
        }

        private void SetEnabled(bool able)
        {
            cmbRemind.Enabled = able;
            dateTimeRemind.Enabled = able;
            txtXczx.Enabled = able;
            txtDhzx.Enabled = able;
            txtTbtx.Enabled = able;
            txtCjjl.Enabled = able;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MenuSet.remindAdd == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MenuSet.remindDel == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
    }
}
