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
    public partial class SubFormPwd : Form
    {
        public SubFormPwd(Token tk)
        {
            InitializeComponent();
            TheToken = tk;
        }

        private Token TheToken;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (MenuSet.pwdSet == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string strPwd = txtPwd.Text.Trim();
            string strSel = string.Format("SELECT * FROM rhdbs.user_info WHERE user_id='{0}' AND pwd='{1}'", TheToken.LoginUser, strPwd);

            DataTable dt = new DataTable();
            MySqlConnection conn = new MySqlConnection(TheToken.DataConnStr);
            conn.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(strSel, conn);
            try
            {
                da.Fill(dt);
            }
            catch
            {
                MessageBox.Show("密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (txtPwdNew.Text != txtPwdNew2.Text)
                {
                    MessageBox.Show("两次输入密码不一致！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dt.Rows[0].BeginEdit();
                dt.Rows[0]["pwd"] = txtPwdNew.Text;
                dt.Rows[0].EndEdit();
                MySqlCommandBuilder scb = new MySqlCommandBuilder(da);
                //scb.ReturnGeneratedIdentifiers = false;
                da.Update(dt.GetChanges());
                dt.AcceptChanges();
            }
            catch
            {
                MessageBox.Show("密码错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("密码修改成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
