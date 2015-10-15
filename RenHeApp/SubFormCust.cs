using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace RenHeApp
{
    public partial class SubFormCust : SubFormBase
    {
        public SubFormCust(Token tk)
        {
            InitializeComponent();
            TheToken = tk;

            try
            {
                string strSql = "SELECT * FROM rhdbs.cust_info";
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
        }

        private MySqlDataAdapter dataAdapter;
        private Token TheToken;

        private void SubFormCust_Load(object sender, EventArgs e)
        {
            Init();
            cmbSex.SelectedIndex = 1;
            cmbRemind.SelectedIndex = 1;
            cmbLevel.SelectedIndex = 3;
            cmbDeal.SelectedIndex = 1;
            cmbAsk.SelectedIndex = 0;
        }

        private void btnSel_Click(object sender, EventArgs e)
        {
            try
            {
                btnDtl.Enabled = true;
                if (TheToken.Role == 0)
                {
                    btnAdd.Enabled = true;
                    btnDel.Enabled = true;
                    btnUpt.Enabled = true;
                }

                MySqlConnection conn = new MySqlConnection(TheToken.DataConnStr);
                conn.Open();
                string strSelName = tXtSelName.Text.Trim();
                string strSel = string.Format("SELECT * FROM rhdbs.cust_info WHERE cust_name='{0}' OR '{0}'=''", strSelName);
                MySqlDataAdapter da = new MySqlDataAdapter(strSel, conn);
                rhdbs.cust_info.Clear();
                // rhdbs.cust_info.AcceptChanges();
                da.Fill(rhdbs.cust_info);
            }
            catch
            {
                MessageBox.Show("查询客户信息失败！");
            }
        }

        private void btnDtl_Click(object sender, EventArgs e)
        {
            OperType = OperateType.Detail;
            SwitchAdministration();
            SetEnabled(false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperType = OperateType.Insert;
            SwitchAdministration();
            EmptyValue();
            SetEnabled(true);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            OperType = OperateType.Delete;
            SwitchAdministration();
            SetEnabled(false);
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            OperType = OperateType.Update;
            SwitchAdministration();
            SetEnabled(true);
        }

        private bool InsertCustInfo()
        {
            try
            {
                rhdbs.cust_info.Addcust_infoRow(
                                                txtName.Text,
                                                cmbSex.Text,
                                                dateTimeBirth.Value,
                                                null,
                                                null,
                                                txtAddress.Text,
                                                txtCompany.Text,
                                                txtPhone.Text,
                                                null,
                                                null,
                                                null,
                                                txtSource.Text,
                                                cmbLevel.Text,
                                                cmbAsk.Text,
                                                dateTimeAsk.Value,
                                                cmbDeal.Text,
                                                null,
                                                cmbRemind.Text,
                                                dateTimeRemind.Value,
                                                txtXczx.Text,
                                                txtDhzx.Text,
                                                txtTbtx.Text,
                                                txtCjjl.Text,
                                                GetByteImage(picBox.Image),
                                                DateTime.Now);
                MySqlCommandBuilder scb = new MySqlCommandBuilder(dataAdapter);
                scb.ReturnGeneratedIdentifiers = false;
                dataAdapter.Update(rhdbs.cust_info.GetChanges());
                rhdbs.cust_info.AcceptChanges();
            }
            catch (Exception ex)
            {
                if (ex.Source == "MySql.Data")
                {
                    rhdbs.cust_info.Rows[rhdbs.cust_info.Rows.Count-1].Delete();
                    rhdbs.cust_info.AcceptChanges();
                }
                return false;
            }

            return true;
        }

        private bool DeleteCustInfo()
        {
            try
            {
                rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index].Delete();
                MySqlCommandBuilder scb = new MySqlCommandBuilder(dataAdapter);
                scb.ReturnGeneratedIdentifiers = false;
                dataAdapter.Update(rhdbs.cust_info.GetChanges());
                rhdbs.cust_info.AcceptChanges();
            }
            catch
            {
                return false;
            }

            return true;
        }

        private bool UpdateCustInfo()
        {
            try
            {
                rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index].BeginEdit();
                rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["cust_name"] = txtName.Text;
                rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["sex"] = cmbSex.Text;
                rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["birthday"] = dateTimeBirth.Value;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["address"] = txtAddress.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["company"] = txtCompany.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["phone"] = txtPhone.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["source"] = txtSource.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["level"] = cmbLevel.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["ask_flag"] = cmbAsk.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["ask_time"] = dateTimeAsk.Value;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["deal_flag"] = cmbDeal.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["remind_flag"] = cmbRemind.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["remind_time"] = dateTimeRemind.Value;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["xczx"] = txtXczx.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["dhzx"] = txtDhzx.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["tbtx"] = txtTbtx.Text;
	            rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["cjjl"] = txtCjjl.Text;
                rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index]["photo"] = GetByteImage(picBox.Image);
                rhdbs.cust_info.Rows[dataGridView.CurrentRow.Index].EndEdit();
                MySqlCommandBuilder scb = new MySqlCommandBuilder(dataAdapter);
                scb.ReturnGeneratedIdentifiers = false;
                dataAdapter.Update(rhdbs.cust_info.GetChanges());
                rhdbs.cust_info.AcceptChanges();
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
                    if (InsertCustInfo() == false)
                    {
                        SwitchOverview();
                        MessageBox.Show("添加客户失败！");
                        return;
                    }
                    break;
                case OperateType.Delete:
                    if (MessageBox.Show("确定要删除该客户吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (DeleteCustInfo() == false)
                        {
                            SwitchOverview();
                            MessageBox.Show("删除客户失败！");
                            return;
                        }
                    }
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("只能输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "(*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png"; // 过滤文件类型
            fileDialog.InitialDirectory = Application.StartupPath; // 初始目录
            fileDialog.ShowReadOnly = true; // 只读
            fileDialog.RestoreDirectory = true; // 记住上次打开目录
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] bytePic = File.ReadAllBytes(fileDialog.FileName);
                    if (bytePic.Length > 64000)
                    {
                        MessageBox.Show("图片太大！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    picBox.Image = Image.FromStream(new MemoryStream(bytePic));
                }
                catch
                {
                    MessageBox.Show("打开文件失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private byte[] GetByteImage(Image img)
        {
            byte[] bt = null;

            if (img != null)
            {
                using (MemoryStream mostream = new MemoryStream())
                {
                    Bitmap bmp = new Bitmap(img);

                    bmp.Save(mostream, System.Drawing.Imaging.ImageFormat.Jpeg);//将图像以指定的格式存入缓存内存流

                    bt = new byte[mostream.Length];

                    mostream.Position = 0;//设置留的初始位置

                    mostream.Read(bt, 0, Convert.ToInt32(bt.Length));

                }

            }

            return bt;
        }

        private void EmptyValue()
        { 
            txtName.Text = "";
            cmbSex.SelectedIndex = 0;
            dateTimeBirth.Value = DateTime.Now;
            txtAddress.Text = "";
            txtCompany.Text = "";
            txtPhone.Text = "";
            txtSource.Text = "";
            cmbLevel.SelectedIndex = 3;
            cmbAsk.SelectedIndex = 0;
            dateTimeAsk.Value = DateTime.Now;
            cmbDeal.SelectedIndex = 1;
            cmbRemind.SelectedIndex = 1;
            dateTimeRemind.Value = DateTime.Now;
            txtXczx.Text = "";
            txtDhzx.Text = "";
            txtTbtx.Text = "";
            txtCjjl.Text = "";
            picBox.Image = null;
        }

        private void SetEnabled(bool able)
        {
            txtName.Enabled = able;
            cmbSex.Enabled = able;
            dateTimeBirth.Enabled = able;
            txtAddress.Enabled = able;
            txtCompany.Enabled = able;
            txtPhone.Enabled = able;
            txtSource.Enabled = able;
            cmbLevel.Enabled = able;
            cmbAsk.Enabled = able;
            dateTimeAsk.Enabled = able;
            cmbDeal.Enabled = able;
            cmbRemind.Enabled = able;
            dateTimeRemind.Enabled = able;
            txtXczx.Enabled = able;
            txtDhzx.Enabled = able;
            txtTbtx.Enabled = able;
            txtCjjl.Enabled = able;
            picBox.Enabled = able;
            btnPic.Enabled = able;
        }
    }
}
