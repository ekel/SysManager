namespace RenHeApp
{
    partial class SubFormCust
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.cust_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.source = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rhdbs = new RenHeApp.rhdbs();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.custinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.dateTimeAsk = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimeRemind = new System.Windows.Forms.DateTimePicker();
            this.cmbRemind = new System.Windows.Forms.ComboBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbDeal = new System.Windows.Forms.ComboBox();
            this.txtDhzx = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTbtx = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtXczx = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCjjl = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbAsk = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSelName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabSub.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grpBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.grpBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhdbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.SplitterDistance = 51;
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(1186, 466);
            this.splitContainer2.SplitterDistance = 391;
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.txtSelName);
            this.grpBox1.Controls.Add(this.label19);
            this.grpBox1.Size = new System.Drawing.Size(1186, 51);
            // 
            // btnSel
            // 
            this.btnSel.Location = new System.Drawing.Point(753, 17);
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(857, 17);
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(957, 17);
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUpt
            // 
            this.btnUpt.Enabled = false;
            this.btnUpt.Location = new System.Drawing.Point(1051, 17);
            this.btnUpt.Click += new System.EventHandler(this.btnUpt_Click);
            // 
            // btnDtl
            // 
            this.btnDtl.Enabled = false;
            this.btnDtl.Location = new System.Drawing.Point(37, 17);
            this.btnDtl.Click += new System.EventHandler(this.btnDtl_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.SplitterDistance = 458;
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.btnPic);
            this.grpBox2.Controls.Add(this.groupBox1);
            this.grpBox2.Controls.Add(this.dateTimeRemind);
            this.grpBox2.Controls.Add(this.dateTimeAsk);
            this.grpBox2.Controls.Add(this.cmbDeal);
            this.grpBox2.Controls.Add(this.cmbAsk);
            this.grpBox2.Controls.Add(this.cmbLevel);
            this.grpBox2.Controls.Add(this.dateTimeBirth);
            this.grpBox2.Controls.Add(this.cmbRemind);
            this.grpBox2.Controls.Add(this.cmbSex);
            this.grpBox2.Controls.Add(this.label10);
            this.grpBox2.Controls.Add(this.label8);
            this.grpBox2.Controls.Add(this.label13);
            this.grpBox2.Controls.Add(this.label11);
            this.grpBox2.Controls.Add(this.label1);
            this.grpBox2.Controls.Add(this.label12);
            this.grpBox2.Controls.Add(this.label17);
            this.grpBox2.Controls.Add(this.label16);
            this.grpBox2.Controls.Add(this.label15);
            this.grpBox2.Controls.Add(this.label14);
            this.grpBox2.Controls.Add(this.label9);
            this.grpBox2.Controls.Add(this.label7);
            this.grpBox2.Controls.Add(this.txtCjjl);
            this.grpBox2.Controls.Add(this.txtXczx);
            this.grpBox2.Controls.Add(this.txtTbtx);
            this.grpBox2.Controls.Add(this.txtDhzx);
            this.grpBox2.Controls.Add(this.txtSource);
            this.grpBox2.Controls.Add(this.label6);
            this.grpBox2.Controls.Add(this.label5);
            this.grpBox2.Controls.Add(this.txtCompany);
            this.grpBox2.Controls.Add(this.label4);
            this.grpBox2.Controls.Add(this.txtAddress);
            this.grpBox2.Controls.Add(this.label3);
            this.grpBox2.Controls.Add(this.txtPhone);
            this.grpBox2.Controls.Add(this.label20);
            this.grpBox2.Controls.Add(this.label2);
            this.grpBox2.Controls.Add(this.txtAge);
            this.grpBox2.Controls.Add(this.txtName);
            this.grpBox2.Size = new System.Drawing.Size(1186, 458);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(939, 12);
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1089, 12);
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cust_id,
            this.cust_name,
            this.sex,
            this.age,
            this.level,
            this.source});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1186, 391);
            this.dataGridView.TabIndex = 3;
            // 
            // cust_id
            // 
            this.cust_id.HeaderText = "客户号";
            this.cust_id.Name = "cust_id";
            this.cust_id.ReadOnly = true;
            // 
            // cust_name
            // 
            this.cust_name.HeaderText = "客户姓名";
            this.cust_name.Name = "cust_name";
            this.cust_name.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "年龄";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            // 
            // level
            // 
            this.level.HeaderText = "服务等级";
            this.level.Name = "level";
            this.level.ReadOnly = true;
            // 
            // source
            // 
            this.source.HeaderText = "来源";
            this.source.Name = "source";
            this.source.ReadOnly = true;
            // 
            // rhdbs
            // 
            this.rhdbs.DataSetName = "rhdbs";
            this.rhdbs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "性别";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "出生日期";
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "phone", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtPhone.Location = new System.Drawing.Point(62, 87);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 0;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // custinfoBindingSource
            // 
            this.custinfoBindingSource.DataMember = "cust_info";
            this.custinfoBindingSource.DataSource = this.rhdbs;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "电话";
            // 
            // txtAddress
            // 
            this.txtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "address", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtAddress.Location = new System.Drawing.Point(62, 53);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(300, 21);
            this.txtAddress.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "住址";
            // 
            // txtCompany
            // 
            this.txtCompany.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "company", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCompany.Location = new System.Drawing.Point(450, 53);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(200, 21);
            this.txtCompany.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(392, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "工作单位";
            // 
            // txtSource
            // 
            this.txtSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "source", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtSource.Location = new System.Drawing.Point(62, 121);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(184, 21);
            this.txtSource.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "来源";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "服务等级";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(435, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "是否成交";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 1;
            this.label12.Text = "咨询方式";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "cust_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtName.Location = new System.Drawing.Point(62, 19);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 21);
            this.txtName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "姓名";
            // 
            // cmbSex
            // 
            this.cmbSex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "sex", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(206, 19);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(40, 20);
            this.cmbSex.TabIndex = 2;
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.CustomFormat = "yyyy/MM/dd";
            this.dateTimeBirth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.custinfoBindingSource, "birthday", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimeBirth.Location = new System.Drawing.Point(450, 19);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(127, 21);
            this.dateTimeBirth.TabIndex = 3;
            this.dateTimeBirth.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dateTimeBirth.ValueChanged += new System.EventHandler(this.dateTimeBirth_ValueChanged);
            // 
            // dateTimeAsk
            // 
            this.dateTimeAsk.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimeAsk.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.custinfoBindingSource, "ask_time", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimeAsk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeAsk.Location = new System.Drawing.Point(253, 155);
            this.dateTimeAsk.Name = "dateTimeAsk";
            this.dateTimeAsk.Size = new System.Drawing.Size(159, 21);
            this.dateTimeAsk.TabIndex = 3;
            this.dateTimeAsk.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "咨询时间";
            // 
            // picBox
            // 
            this.picBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox.Location = new System.Drawing.Point(3, 17);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(133, 149);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 4;
            this.picBox.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 1;
            this.label11.Text = "是否提醒";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(144, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 1;
            this.label13.Text = "提醒时间";
            // 
            // dateTimeRemind
            // 
            this.dateTimeRemind.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimeRemind.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.custinfoBindingSource, "remind_time", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimeRemind.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRemind.Location = new System.Drawing.Point(203, 189);
            this.dateTimeRemind.Name = "dateTimeRemind";
            this.dateTimeRemind.Size = new System.Drawing.Size(159, 21);
            this.dateTimeRemind.TabIndex = 3;
            this.dateTimeRemind.Value = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            // 
            // cmbRemind
            // 
            this.cmbRemind.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "remind_flag", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbRemind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemind.FormattingEnabled = true;
            this.cmbRemind.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbRemind.Location = new System.Drawing.Point(86, 189);
            this.cmbRemind.Name = "cmbRemind";
            this.cmbRemind.Size = new System.Drawing.Size(40, 20);
            this.cmbRemind.TabIndex = 2;
            // 
            // cmbLevel
            // 
            this.cmbLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "level", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbLevel.Location = new System.Drawing.Point(334, 121);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(40, 20);
            this.cmbLevel.TabIndex = 2;
            // 
            // cmbDeal
            // 
            this.cmbDeal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "deal_flag", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbDeal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDeal.FormattingEnabled = true;
            this.cmbDeal.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbDeal.Location = new System.Drawing.Point(494, 155);
            this.cmbDeal.Name = "cmbDeal";
            this.cmbDeal.Size = new System.Drawing.Size(40, 20);
            this.cmbDeal.TabIndex = 2;
            // 
            // txtDhzx
            // 
            this.txtDhzx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDhzx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "dhzx", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtDhzx.Location = new System.Drawing.Point(112, 252);
            this.txtDhzx.Multiline = true;
            this.txtDhzx.Name = "txtDhzx";
            this.txtDhzx.Size = new System.Drawing.Size(300, 84);
            this.txtDhzx.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(26, 288);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 1;
            this.label14.Text = "电话咨询情况";
            // 
            // txtTbtx
            // 
            this.txtTbtx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTbtx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "tbtx", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTbtx.Location = new System.Drawing.Point(112, 354);
            this.txtTbtx.Multiline = true;
            this.txtTbtx.Name = "txtTbtx";
            this.txtTbtx.Size = new System.Drawing.Size(300, 84);
            this.txtTbtx.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "特别提醒";
            // 
            // txtXczx
            // 
            this.txtXczx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtXczx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "xczx", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtXczx.Location = new System.Drawing.Point(598, 252);
            this.txtXczx.Multiline = true;
            this.txtXczx.Name = "txtXczx";
            this.txtXczx.Size = new System.Drawing.Size(300, 84);
            this.txtXczx.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(512, 288);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "现场咨询情况";
            // 
            // txtCjjl
            // 
            this.txtCjjl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtCjjl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "cjjl", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCjjl.Location = new System.Drawing.Point(598, 354);
            this.txtCjjl.Multiline = true;
            this.txtCjjl.Name = "txtCjjl";
            this.txtCjjl.Size = new System.Drawing.Size(300, 84);
            this.txtCjjl.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(512, 390);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 1;
            this.label17.Text = "成交记录";
            // 
            // cmbAsk
            // 
            this.cmbAsk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.custinfoBindingSource, "ask_flag", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbAsk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAsk.FormattingEnabled = true;
            this.cmbAsk.Items.AddRange(new object[] {
            "电话咨询",
            "现场咨询",
            "电话+现场"});
            this.cmbAsk.Location = new System.Drawing.Point(86, 155);
            this.cmbAsk.Name = "cmbAsk";
            this.cmbAsk.Size = new System.Drawing.Size(76, 20);
            this.cmbAsk.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.picBox);
            this.groupBox1.Location = new System.Drawing.Point(983, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 169);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户照片";
            // 
            // btnPic
            // 
            this.btnPic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPic.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPic.Location = new System.Drawing.Point(986, 194);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(133, 32);
            this.btnPic.TabIndex = 6;
            this.btnPic.Text = "照片管理";
            this.btnPic.UseVisualStyleBackColor = true;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(35, 23);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 0;
            this.label19.Text = "客户姓名";
            // 
            // txtSelName
            // 
            this.txtSelName.Location = new System.Drawing.Point(94, 20);
            this.txtSelName.Name = "txtSelName";
            this.txtSelName.Size = new System.Drawing.Size(100, 21);
            this.txtSelName.TabIndex = 1;
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(314, 19);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(48, 21);
            this.txtAge.TabIndex = 0;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(279, 23);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 1;
            this.label20.Text = "年龄";
            // 
            // SubFormCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Name = "SubFormCust";
            this.Text = "客户管理";
            this.Load += new System.EventHandler(this.SubFormCust_Load);
            this.tabSub.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.grpBox2.ResumeLayout(false);
            this.grpBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhdbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.custinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private rhdbs rhdbs;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.DateTimePicker dateTimeAsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.DateTimePicker dateTimeRemind;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbRemind;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbDeal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCjjl;
        private System.Windows.Forms.TextBox txtXczx;
        private System.Windows.Forms.TextBox txtTbtx;
        private System.Windows.Forms.TextBox txtDhzx;
        private System.Windows.Forms.ComboBox cmbAsk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.TextBox txtSelName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.BindingSource custinfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn level;
        private System.Windows.Forms.DataGridViewTextBoxColumn source;
    }
}