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
    public partial class RemindDialog2 : Form
    {
        public RemindDialog2(ref rhdbs.birthRemindDataTable dt)
        {
            InitializeComponent();
            dataTable = dt;

            AllCount = dataTable.Rows.Count;
            AllPages = (Int32)Math.Ceiling(Convert.ToDouble(AllCount) / 10);
        }

        private DataTable dataTable;
        private Int32 AllCount;
        private Int32 CurPage;
        private Int32 AllPages;

        private void RemindDialog_Load(object sender, EventArgs e)
        {
            CurPage = 1;

            ChangeGridView();

            btnFirst.Enabled = false;
            btnPrev.Enabled = false;
            if (CurPage < AllPages)
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            CurPage = 1;

            ChangeGridView();

            btnFirst.Enabled = false;
            btnPrev.Enabled = false;
            if (CurPage < AllPages)
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurPage > 1)
            {
                CurPage--;
            }

            ChangeGridView();

            btnNext.Enabled = true;
            btnLast.Enabled = true;
            if (CurPage != 1)
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
            }
            else
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurPage < AllPages)
            {
                CurPage++;
            }

            ChangeGridView();

            btnFirst.Enabled = true;
            btnPrev.Enabled = true;
            if (CurPage < AllPages)
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            CurPage = AllPages;

            ChangeGridView();

            btnNext.Enabled = false;
            btnLast.Enabled = false;
            if (AllPages != 1)
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
            }
            else
            {
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
            }
        }

        private void ChangeColor()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                string strLevel = dataGridView.Rows[i].Cells["level"].Value.ToString();
                switch (strLevel)
                {
                    case "A":
                        // 橘红色
                        dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                        break;
                    case "B":
                        // 橙色
                        dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Orange;
                        break;
                    case "C":
                        // 黄色
                        dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case "D":
                        // 浅绿色
                        dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                        break;
                    default:
                        break;
                }
            }
        }

        private void ChangeGridView()
        {
            string strText = string.Format("第{0}页,共{1}页", CurPage, AllPages);
            labelText.Text = strText;

            dataGridView.Rows.Clear();
            for (int i = (CurPage - 1) * 10; i < CurPage * 10; i++)
            {
                if (i < AllCount)
                {
                    int index = dataGridView.Rows.Add();
                    DataGridViewRow row = dataGridView.Rows[index];
                    row.Cells["id"].Value = i + 1;
                    row.Cells["name"].Value = dataTable.Rows[i]["cust_name"].ToString();
                    row.Cells["phone"].Value = dataTable.Rows[i]["phone"].ToString();
                    row.Cells["level"].Value = dataTable.Rows[i]["level"].ToString();
                }
            }
            ChangeColor();
        }
    }
}
