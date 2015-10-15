using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RenHeApp
{
    public partial class RemindDialog : Form
    {
        public RemindDialog(ref DataTable dt)
        {
            InitializeComponent();
            dataTable = dt;
        }

        private DataTable dataTable;
        private Int32 Count;

        private void RemindDialog_Load(object sender, EventArgs e)
        {
            Count = 0;
            txtName.Text = dataTable.Rows[Count]["cust_name"].ToString();
            txtSex.Text  = dataTable.Rows[Count]["sex"].ToString();
            txtTbtx.Text = dataTable.Rows[Count]["tbtx"].ToString();

            btnFirst.Enabled = false;
            if (dataTable.Rows.Count > 1)
            {
                btnNext.Enabled = true;
            }
            btnLast.Enabled = false;
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            Count = 0;
            txtName.Text = dataTable.Rows[Count]["cust_name"].ToString();
            txtSex.Text = dataTable.Rows[Count]["sex"].ToString();
            txtTbtx.Text = dataTable.Rows[Count]["tbtx"].ToString();

            btnFirst.Enabled = false;
            if (dataTable.Rows.Count > 1)
            {
                btnNext.Enabled = true;
            }
            btnLast.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (Count < dataTable.Rows.Count-1)
            {
                Count++;
            }                
 
            txtName.Text = dataTable.Rows[Count]["cust_name"].ToString();
            txtSex.Text = dataTable.Rows[Count]["sex"].ToString();
            txtTbtx.Text = dataTable.Rows[Count]["tbtx"].ToString();

            btnFirst.Enabled = true;
            if (Count == (dataTable.Rows.Count-1))
            {
                btnNext.Enabled = false;
            }
            btnLast.Enabled = true;
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (Count > 0)
            {
                Count--;
            }
            txtName.Text = dataTable.Rows[Count]["cust_name"].ToString();
            txtSex.Text = dataTable.Rows[Count]["sex"].ToString();
            txtTbtx.Text = dataTable.Rows[Count]["tbtx"].ToString();

            if (Count == 0)
            {
                btnFirst.Enabled = false;
                btnLast.Enabled = false;
            }
            btnNext.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清除该客户的提醒吗?","警告",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                dataTable.Rows[Count].BeginEdit();
                dataTable.Rows[Count]["remind_flag"] = "否";
                dataTable.Rows[Count].EndEdit();
            }
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要清除全部提醒吗?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    dataTable.Rows[i].BeginEdit();
                    dataTable.Rows[i]["remind_flag"] = "否";
                    dataTable.Rows[i].EndEdit();
                }
            }
        }
    }
}
