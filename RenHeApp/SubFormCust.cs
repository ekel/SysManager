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
        }

        private Token TheToken;
        private Int32 CurCustId;
        private MySqlDataAdapter CustDaDetails;
        private MySqlDataAdapter CustDaPhotos;

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
            if (MenuSet.custSel == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SelectCustInfo() == false)
            {
                MessageBox.Show("查询客户失败！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            btnDtl.Enabled = true;
            if (TheToken.Role == 0)
            {
                btnAdd.Enabled = true;
                btnDel.Enabled = true;
                btnUpt.Enabled = true;
            }
        }

        private void btnDtl_Click(object sender, EventArgs e)
        {
            if (MenuSet.custSel == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OperType = OperateType.Detail;

            CurCustId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["cust_id"].Value.ToString());
            if (GetCustInfoById(CurCustId) == false)
            {
                rhdbs.cust_info.Clear();
                rhdbs.cust_photo.Clear();
                MessageBox.Show("获取客户详细信息失败！","错误",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            SwitchAdministration();
            SetEnabled(false);
            txtAge.Text = Convert.ToString(DateTime.Now.Year - dateTimeBirth.Value.Year);

            if (rhdbs.cust_photo.Rows.Count > 0)
            {
                picBox.Image = GetImageByBytes((byte[])rhdbs.cust_photo.Rows[0]["photo"]);
            }
            else
            {
                picBox.Image = null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (MenuSet.custAdd == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OperType = OperateType.Insert;

            CurCustId = GenerateCustId();
            GetCustInfoById(CurCustId); // 此处只是为了获得数据适配器

            SwitchAdministration();
            SetEnabled(true);
            InitInsertCustInfo();
            txtAge.Text = Convert.ToString(DateTime.Now.Year - dateTimeBirth.Value.Year);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MenuSet.custDel == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OperType = OperateType.Delete;

            CurCustId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["cust_id"].Value.ToString());
            if (GetCustInfoById(CurCustId) == false)
            {
                rhdbs.cust_info.Clear();
                rhdbs.cust_photo.Clear();
                MessageBox.Show("获取客户详细信息失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SwitchAdministration();
            SetEnabled(false);
            txtAge.Text = Convert.ToString(DateTime.Now.Year - dateTimeBirth.Value.Year);

            if (rhdbs.cust_photo.Rows.Count > 0)
            {
                picBox.Image = GetImageByBytes((byte[])rhdbs.cust_photo.Rows[0]["photo"]);
            }
            else
            {
                picBox.Image = null;
            }
        }

        private void btnUpt_Click(object sender, EventArgs e)
        {
            if (MenuSet.custUpt == '0')
            {
                MessageBox.Show("没有设置该权限！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            OperType = OperateType.Update;

            CurCustId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["cust_id"].Value.ToString());
            if (GetCustInfoById(CurCustId) == false)
            {
                rhdbs.cust_info.Clear();
                rhdbs.cust_photo.Clear();
                MessageBox.Show("获取客户详细信息失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SwitchAdministration();
            SetEnabled(true);
            txtAge.Text = Convert.ToString(DateTime.Now.Year - dateTimeBirth.Value.Year);

            if (rhdbs.cust_photo.Rows.Count > 0)
            {
                picBox.Image = GetImageByBytes((byte[])rhdbs.cust_photo.Rows[0]["photo"]);
            }
            else
            {
                picBox.Image = null;
            }
        }

        private bool GetCustInfoById(Int64 iCustId)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(TheToken.DataConnStr);
                conn.Open();
                // 客户详细资料
                string sql1 = string.Format("SELECT * FROM cust_info WHERE cust_id={0}",
                    iCustId);
                CustDaDetails = new MySqlDataAdapter(sql1, conn);
                MySqlCommandBuilder cb1 = new MySqlCommandBuilder(CustDaDetails);
                //cb1.ReturnGeneratedIdentifiers = false;
                rhdbs.cust_info.Clear();
                CustDaDetails.Fill(rhdbs.cust_info);

                // 客户照片
                string sql2 = string.Format("SELECT * FROM cust_photo WHERE cust_id={0} ORDER BY photo_id",
                    iCustId);
                CustDaPhotos = new MySqlDataAdapter(sql2, conn);
                MySqlCommandBuilder cb2 = new MySqlCommandBuilder(CustDaPhotos);
                //cb2.ReturnGeneratedIdentifiers = false;
                rhdbs.cust_photo.Clear();
                CustDaPhotos.Fill(rhdbs.cust_photo);
                conn.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool SelectCustInfo()
        {
            try
            {
                // 数据库层
                string cond = string.Format("cust_name='{0}' OR '{0}'=''", txtSelName.Text.Trim());
                string sql = string.Format("SELECT {0} FROM {1} WHERE {2}",
                    "cust_id,cust_name,sex,birthday,level,source",
                    "rhdbs.cust_info",
                    cond);
                MySqlConnection conn = new MySqlConnection(TheToken.DataConnStr);
                conn.Open();
                MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter(sql, conn);
                rhdbs.cust_info.Clear();
                sqlDataAdapter.Fill(rhdbs.cust_info);
                conn.Close();

                // 界面层
                dataGridView.Rows.Clear();
                for (int i = 0; i < rhdbs.cust_info.Rows.Count; i++)
                {
                    int index = dataGridView.Rows.Add();
                    DataGridViewRow row = dataGridView.Rows[index];
                    row.Cells["cust_id"].Value = rhdbs.cust_info.Rows[i]["cust_id"].ToString(); //客户号
                    row.Cells["cust_name"].Value = rhdbs.cust_info.Rows[i]["cust_name"].ToString(); //客户姓名
                    row.Cells["sex"].Value = rhdbs.cust_info.Rows[i]["sex"].ToString(); //性别
                    DateTime birthday = (DateTime)rhdbs.cust_info.Rows[i]["birthday"];
                    row.Cells["age"].Value = Convert.ToString(DateTime.Now.Year - birthday.Year); //年龄
                    row.Cells["level"].Value = rhdbs.cust_info.Rows[i]["level"].ToString(); //服务等级
                    row.Cells["source"].Value = rhdbs.cust_info.Rows[i]["source"].ToString(); //来源
                }
                RefreshDgvAllRows();

                return true;
            }
            catch
            { 
                return false;
            }
        }

        private bool InsertCustInfo()
        {
            try
            {
                // 内存操作
                rhdbs.cust_info.Addcust_infoRow(
                    CurCustId,
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
                    DateTime.Now
                );

                // 数据库操作
                // 添加客户信息
                MySqlCommandBuilder cb1 = new MySqlCommandBuilder(CustDaDetails);
                //cb1.ReturnGeneratedIdentifiers = false;
                CustDaDetails.Update(rhdbs.cust_info.GetChanges());
                rhdbs.cust_info.AcceptChanges();
                // 添加客户照片
                if (rhdbs.cust_photo.GetChanges() != null)
                {
                    MySqlCommandBuilder cb2 = new MySqlCommandBuilder(CustDaPhotos);
                    //cb2.ReturnGeneratedIdentifiers = false;
                    CustDaPhotos.Update(rhdbs.cust_photo.GetChanges());
                    rhdbs.cust_photo.AcceptChanges();
                }

                // 界面操作
                int index = dataGridView.Rows.Add();
                DataGridViewRow row = dataGridView.Rows[index];
                row.Cells["cust_id"].Value = rhdbs.cust_info.Rows[0]["cust_id"].ToString(); //客户号
                row.Cells["cust_name"].Value = rhdbs.cust_info.Rows[0]["cust_name"].ToString();
                row.Cells["sex"].Value = rhdbs.cust_info.Rows[0]["sex"].ToString();
                DateTime birthday = (DateTime)rhdbs.cust_info.Rows[0]["birthday"];
                row.Cells["age"].Value = Convert.ToString(DateTime.Now.Year - birthday.Year);
                row.Cells["level"].Value = rhdbs.cust_info.Rows[0]["level"].ToString();
                row.Cells["source"].Value = rhdbs.cust_info.Rows[0]["source"].ToString();
                RefreshDgvOneRow(row);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool DeleteCustInfo()
        {
            try
            {
                // 数据库操作
                // 删除客户信息
                rhdbs.cust_info.Rows[0].Delete();
                MySqlCommandBuilder cb1 = new MySqlCommandBuilder(CustDaDetails);
                //cb1.ReturnGeneratedIdentifiers = false;
                CustDaDetails.Update(rhdbs.cust_info.GetChanges());
                rhdbs.cust_info.AcceptChanges();
                // 删除客户照片
                if (rhdbs.cust_photo.GetChanges() != null)
                {
                    for (int i = 0; i < rhdbs.cust_photo.Rows.Count; i++)
                    {
                        rhdbs.cust_photo.Rows[i].Delete();
                    }
                    MySqlCommandBuilder cb2 = new MySqlCommandBuilder(CustDaPhotos);
                    //cb2.ReturnGeneratedIdentifiers = false;
                    CustDaPhotos.Update(rhdbs.cust_photo.GetChanges());
                    rhdbs.cust_photo.AcceptChanges();
                }

                // 界面操作
                int index = dataGridView.SelectedRows[0].Index;
                dataGridView.Rows.RemoveAt(index);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool UpdateCustInfo()
        {
            try
            {
                // 数据库操作
                // 修改客户信息
                rhdbs.cust_info.Rows[0].BeginEdit();
                rhdbs.cust_info.Rows[0]["cust_name"] = txtName.Text;
                rhdbs.cust_info.Rows[0]["sex"] = cmbSex.Text;
                rhdbs.cust_info.Rows[0]["birthday"] = dateTimeBirth.Value;
                rhdbs.cust_info.Rows[0]["address"] = txtAddress.Text;
                rhdbs.cust_info.Rows[0]["company"] = txtCompany.Text;
                rhdbs.cust_info.Rows[0]["phone"] = txtPhone.Text;
                rhdbs.cust_info.Rows[0]["source"] = txtSource.Text;
                rhdbs.cust_info.Rows[0]["level"] = cmbLevel.Text;
                rhdbs.cust_info.Rows[0]["ask_flag"] = cmbAsk.Text;
                rhdbs.cust_info.Rows[0]["ask_time"] = dateTimeAsk.Value;
                rhdbs.cust_info.Rows[0]["deal_flag"] = cmbDeal.Text;
                rhdbs.cust_info.Rows[0]["remind_flag"] = cmbRemind.Text;
                rhdbs.cust_info.Rows[0]["remind_time"] = dateTimeRemind.Value;
                rhdbs.cust_info.Rows[0]["xczx"] = txtXczx.Text;
                rhdbs.cust_info.Rows[0]["dhzx"] = txtDhzx.Text;
                rhdbs.cust_info.Rows[0]["tbtx"] = txtTbtx.Text;
                rhdbs.cust_info.Rows[0]["cjjl"] = txtCjjl.Text;
                rhdbs.cust_info.Rows[0].EndEdit();
                MySqlCommandBuilder cb1 = new MySqlCommandBuilder(CustDaDetails);
                //scb.ReturnGeneratedIdentifiers = false;
                CustDaDetails.Update(rhdbs.cust_info.GetChanges());
                rhdbs.cust_info.AcceptChanges();
                // 修改客户照片
                if (rhdbs.cust_photo.GetChanges() != null)
                {
                    MySqlCommandBuilder cb2 = new MySqlCommandBuilder(CustDaPhotos);
                    //cb2.ReturnGeneratedIdentifiers = false;
                    CustDaPhotos.Update(rhdbs.cust_photo.GetChanges());
                    rhdbs.cust_photo.AcceptChanges();
                }

                // 界面操作
                int index = dataGridView.CurrentRow.Index;
                DataGridViewRow row = dataGridView.Rows[index];
                row.Cells["cust_id"].Value = rhdbs.cust_info.Rows[0]["cust_id"].ToString(); //客户号
                row.Cells["cust_name"].Value = rhdbs.cust_info.Rows[0]["cust_name"].ToString();
                row.Cells["sex"].Value = rhdbs.cust_info.Rows[0]["sex"].ToString();
                DateTime birthday = (DateTime)rhdbs.cust_info.Rows[0]["birthday"];
                row.Cells["age"].Value = Convert.ToString(DateTime.Now.Year - birthday.Year);
                row.Cells["level"].Value = rhdbs.cust_info.Rows[0]["level"].ToString();
                row.Cells["source"].Value = rhdbs.cust_info.Rows[0]["source"].ToString();
                RefreshDgvOneRow(row);

                return true;
            }
            catch
            {
                return false;
            }
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
                        MessageBox.Show("添加客户失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    break;
                case OperateType.Delete:
                    if (MessageBox.Show("确定要删除该客户吗？","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        if (DeleteCustInfo() == false)
                        {
                            SwitchOverview();
                            MessageBox.Show("删除客户失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    break;
                case OperateType.Update:
                    if (UpdateCustInfo() == false)
                    {
                        SwitchOverview();
                        MessageBox.Show("修改客户失败！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dateTimeBirth_ValueChanged(object sender, EventArgs e)
        {
            string strAge = Convert.ToString(DateTime.Now.Year - dateTimeBirth.Value.Year);
            txtAge.Text = strAge;
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("只能输入数字", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        }

        private void InitInsertCustInfo()
        {
            txtName.Text = "";
            cmbSex.SelectedIndex = 1;
            dateTimeBirth.Value = DateTime.Now;
            txtAddress.Text = "";
            txtCompany.Text = "";
            txtSource.Text = "";
            cmbLevel.SelectedIndex = 3;
            cmbAsk.SelectedIndex = 2;
            dateTimeAsk.Value = DateTime.Now;
            cmbDeal.SelectedIndex = 1;
            cmbRemind.SelectedIndex = 1;
            txtDhzx.Text = "";
            txtXczx.Text = "";
            txtTbtx.Text = "";
            txtCjjl.Text = "";
            picBox.Image = null;
        }

        private void RefreshDgvAllRows()
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                RefreshDgvRowColor(dataGridView.Rows[i]);
            }

            // 按服务等级升序排列
            dataGridView.Sort(dataGridView.Columns["level"], ListSortDirection.Ascending);
        }

        private void RefreshDgvOneRow(DataGridViewRow row)
        {
            RefreshDgvRowColor(row);

            // 按服务等级升序排列
            dataGridView.Sort(dataGridView.Columns["level"], ListSortDirection.Ascending);
        }

        private void RefreshDgvRowColor(DataGridViewRow row)
        {
            switch (row.Cells["level"].Value.ToString())
            {
                case "A":
                    // 橘红色
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                    break;
                case "B":
                    // 橙色
                    row.DefaultCellStyle.BackColor = Color.Orange;
                    break;
                case "C":
                    // 黄色
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                    break;
                case "D":
                    // 浅绿色
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                    break;
                default:
                    break;
            }
        }

        private void btnPic_Click(object sender, EventArgs e)
        {
            rhdbs.cust_photoDataTable dt = rhdbs.cust_photo;
            bool view = false;
            if (OperType == OperateType.Detail)
            {
                view = true;
            }
            SubFormPhoto frmPhoto = new SubFormPhoto(ref dt, CurCustId, view);
            frmPhoto.ShowDialog();
            picBox.Image = GetImageByBytes((byte[])rhdbs.cust_photo.Rows[0]["photo"]);
        }

        //将二进制数据转换成Image
        private Image GetImageByBytes(byte[] bytes)
        {
            Image photo = null;

            MemoryStream ms = new MemoryStream(bytes);
            ms.Write(bytes, 0, bytes.Length);
            photo = Image.FromStream(ms, true);

            return photo;
        }

        private Int32 GenerateCustId()
        {
            Int32 iCustId = 0;
            MySqlConnection sqlCon = new MySqlConnection(TheToken.DataConnStr);
            sqlCon.Open();

            string strSql = string.Format("SELECT MAX(cust_id) FROM rhdbs.cust_info");
            MySqlCommand sqlCmd = new MySqlCommand(strSql, sqlCon);
            MySqlDataReader sqlRdr = sqlCmd.ExecuteReader();
            if (sqlRdr.Read())
            {
                string sCustId = sqlRdr[0].ToString();
                if (sCustId == "")
                {
                    iCustId = 1;
                }
                else
                {
                    iCustId = Convert.ToInt32(sCustId) + 1;
                }
            }
            else
            {
                iCustId = 1;
            }
            sqlRdr.Close();
            sqlCon.Close();

            return iCustId;
        } 
    }
}
