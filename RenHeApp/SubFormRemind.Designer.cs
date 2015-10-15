namespace RenHeApp
{
    partial class SubFormRemind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remindflagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remindtimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rhdbs = new RenHeApp.rhdbs();
            this.dateTimeRemind = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbRemind = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCjjl = new System.Windows.Forms.TextBox();
            this.txtXczx = new System.Windows.Forms.TextBox();
            this.txtTbtx = new System.Windows.Forms.TextBox();
            this.txtDhzx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSelName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.cmbSelRmd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSelLvl = new System.Windows.Forms.ComboBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.remindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhdbs)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView);
            // 
            // grpBox1
            // 
            this.grpBox1.Controls.Add(this.cmbSelLvl);
            this.grpBox1.Controls.Add(this.label5);
            this.grpBox1.Controls.Add(this.cmbSelRmd);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Controls.Add(this.txtSelName);
            this.grpBox1.Controls.Add(this.label19);
            // 
            // btnSel
            // 
            this.btnSel.Click += new System.EventHandler(this.btnSel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            // 
            // btnUpt
            // 
            this.btnUpt.Enabled = false;
            this.btnUpt.Click += new System.EventHandler(this.btnUpt_Click);
            // 
            // btnDtl
            // 
            this.btnDtl.Enabled = false;
            this.btnDtl.Click += new System.EventHandler(this.btnDtl_Click);
            // 
            // splitContainer3
            // 
            // 
            // grpBox2
            // 
            this.grpBox2.Controls.Add(this.dateTimeRemind);
            this.grpBox2.Controls.Add(this.dateTimeBirth);
            this.grpBox2.Controls.Add(this.cmbLevel);
            this.grpBox2.Controls.Add(this.cmbSex);
            this.grpBox2.Controls.Add(this.cmbRemind);
            this.grpBox2.Controls.Add(this.label8);
            this.grpBox2.Controls.Add(this.label13);
            this.grpBox2.Controls.Add(this.label11);
            this.grpBox2.Controls.Add(this.label17);
            this.grpBox2.Controls.Add(this.label16);
            this.grpBox2.Controls.Add(this.label15);
            this.grpBox2.Controls.Add(this.label14);
            this.grpBox2.Controls.Add(this.txtCjjl);
            this.grpBox2.Controls.Add(this.txtXczx);
            this.grpBox2.Controls.Add(this.txtTbtx);
            this.grpBox2.Controls.Add(this.txtDhzx);
            this.grpBox2.Controls.Add(this.label4);
            this.grpBox2.Controls.Add(this.label3);
            this.grpBox2.Controls.Add(this.label2);
            this.grpBox2.Controls.Add(this.txtName);
            // 
            // btnOK
            // 
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custidDataGridViewTextBoxColumn,
            this.custnameDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthdayDataGridViewTextBoxColumn,
            this.levelDataGridViewTextBoxColumn,
            this.remindflagDataGridViewTextBoxColumn,
            this.remindtimeDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.remindBindingSource;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1186, 352);
            this.dataGridView.TabIndex = 3;
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "客户号";
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // custnameDataGridViewTextBoxColumn
            // 
            this.custnameDataGridViewTextBoxColumn.DataPropertyName = "cust_name";
            this.custnameDataGridViewTextBoxColumn.HeaderText = "姓名";
            this.custnameDataGridViewTextBoxColumn.Name = "custnameDataGridViewTextBoxColumn";
            this.custnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "性别";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            this.sexDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdayDataGridViewTextBoxColumn
            // 
            this.birthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday";
            this.birthdayDataGridViewTextBoxColumn.HeaderText = "出生日期";
            this.birthdayDataGridViewTextBoxColumn.Name = "birthdayDataGridViewTextBoxColumn";
            this.birthdayDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // levelDataGridViewTextBoxColumn
            // 
            this.levelDataGridViewTextBoxColumn.DataPropertyName = "level";
            this.levelDataGridViewTextBoxColumn.HeaderText = "服务等级";
            this.levelDataGridViewTextBoxColumn.Name = "levelDataGridViewTextBoxColumn";
            this.levelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remindflagDataGridViewTextBoxColumn
            // 
            this.remindflagDataGridViewTextBoxColumn.DataPropertyName = "remind_flag";
            this.remindflagDataGridViewTextBoxColumn.HeaderText = "是否提醒";
            this.remindflagDataGridViewTextBoxColumn.Name = "remindflagDataGridViewTextBoxColumn";
            this.remindflagDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remindtimeDataGridViewTextBoxColumn
            // 
            this.remindtimeDataGridViewTextBoxColumn.DataPropertyName = "remind_time";
            this.remindtimeDataGridViewTextBoxColumn.HeaderText = "提醒时间";
            this.remindtimeDataGridViewTextBoxColumn.Name = "remindtimeDataGridViewTextBoxColumn";
            this.remindtimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remindBindingSource
            // 
            this.remindBindingSource.DataMember = "remind";
            this.remindBindingSource.DataSource = this.rhdbs;
            // 
            // rhdbs
            // 
            this.rhdbs.DataSetName = "rhdbs";
            this.rhdbs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateTimeRemind
            // 
            this.dateTimeRemind.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.dateTimeRemind.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.remindBindingSource, "remind_time", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimeRemind.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeRemind.Location = new System.Drawing.Point(197, 89);
            this.dateTimeRemind.Name = "dateTimeRemind";
            this.dateTimeRemind.Size = new System.Drawing.Size(159, 21);
            this.dateTimeRemind.TabIndex = 22;
            this.dateTimeRemind.Value = new System.DateTime(2015, 10, 12, 0, 0, 0, 0);
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.CustomFormat = "yyyy/MM/dd";
            this.dateTimeBirth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.remindBindingSource, "birthday", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.dateTimeBirth.Enabled = false;
            this.dateTimeBirth.Location = new System.Drawing.Point(325, 28);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(127, 21);
            this.dateTimeBirth.TabIndex = 23;
            this.dateTimeBirth.Value = new System.DateTime(2015, 10, 12, 0, 0, 0, 0);
            // 
            // cmbRemind
            // 
            this.cmbRemind.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindBindingSource, "remind_flag", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbRemind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRemind.FormattingEnabled = true;
            this.cmbRemind.Items.AddRange(new object[] {
            "是",
            "否"});
            this.cmbRemind.Location = new System.Drawing.Point(77, 90);
            this.cmbRemind.Name = "cmbRemind";
            this.cmbRemind.Size = new System.Drawing.Size(40, 20);
            this.cmbRemind.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "服务等级";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(138, 93);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 14;
            this.label13.Text = "提醒时间";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 16;
            this.label11.Text = "是否提醒";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(508, 336);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 12);
            this.label17.TabIndex = 18;
            this.label17.Text = "成交记录";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(508, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 12);
            this.label16.TabIndex = 17;
            this.label16.Text = "现场咨询情况";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(22, 336);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "特别提醒";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 219);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 12);
            this.label14.TabIndex = 10;
            this.label14.Text = "电话咨询情况";
            // 
            // txtCjjl
            // 
            this.txtCjjl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindBindingSource, "cjjl", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtCjjl.Location = new System.Drawing.Point(594, 300);
            this.txtCjjl.Multiline = true;
            this.txtCjjl.Name = "txtCjjl";
            this.txtCjjl.Size = new System.Drawing.Size(300, 84);
            this.txtCjjl.TabIndex = 6;
            // 
            // txtXczx
            // 
            this.txtXczx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindBindingSource, "xczx", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtXczx.Location = new System.Drawing.Point(594, 183);
            this.txtXczx.Multiline = true;
            this.txtXczx.Name = "txtXczx";
            this.txtXczx.Size = new System.Drawing.Size(300, 84);
            this.txtXczx.TabIndex = 7;
            // 
            // txtTbtx
            // 
            this.txtTbtx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindBindingSource, "tbtx", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtTbtx.Location = new System.Drawing.Point(108, 300);
            this.txtTbtx.Multiline = true;
            this.txtTbtx.Name = "txtTbtx";
            this.txtTbtx.Size = new System.Drawing.Size(300, 84);
            this.txtTbtx.TabIndex = 4;
            // 
            // txtDhzx
            // 
            this.txtDhzx.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindBindingSource, "dhzx", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtDhzx.Location = new System.Drawing.Point(108, 183);
            this.txtDhzx.Multiline = true;
            this.txtDhzx.Name = "txtDhzx";
            this.txtDhzx.Size = new System.Drawing.Size(300, 84);
            this.txtDhzx.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "出生日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 12;
            this.label3.Text = "性别";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "姓名";
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindBindingSource, "cust_name", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(53, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(80, 21);
            this.txtName.TabIndex = 8;
            // 
            // txtSelName
            // 
            this.txtSelName.Location = new System.Drawing.Point(111, 31);
            this.txtSelName.Name = "txtSelName";
            this.txtSelName.Size = new System.Drawing.Size(100, 21);
            this.txtSelName.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(52, 34);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 2;
            this.label19.Text = "客户姓名";
            // 
            // cmbSex
            // 
            this.cmbSex.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindBindingSource, "sex", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.Enabled = false;
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(197, 28);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(40, 20);
            this.cmbSex.TabIndex = 20;
            // 
            // cmbLevel
            // 
            this.cmbLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.remindBindingSource, "level", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.cmbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLevel.Enabled = false;
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbLevel.Location = new System.Drawing.Point(536, 28);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(40, 20);
            this.cmbLevel.TabIndex = 20;
            // 
            // cmbSelRmd
            // 
            this.cmbSelRmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelRmd.FormattingEnabled = true;
            this.cmbSelRmd.Items.AddRange(new object[] {
            "是",
            "否",
            " "});
            this.cmbSelRmd.Location = new System.Drawing.Point(427, 31);
            this.cmbSelRmd.Name = "cmbSelRmd";
            this.cmbSelRmd.Size = new System.Drawing.Size(40, 20);
            this.cmbSelRmd.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "是否提醒";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "服务等级";
            // 
            // cmbSelLvl
            // 
            this.cmbSelLvl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelLvl.FormattingEnabled = true;
            this.cmbSelLvl.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            " "});
            this.cmbSelLvl.Location = new System.Drawing.Point(303, 31);
            this.cmbSelLvl.Name = "cmbSelLvl";
            this.cmbSelLvl.Size = new System.Drawing.Size(40, 20);
            this.cmbSelLvl.TabIndex = 22;
            // 
            // SubFormRemind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.Name = "SubFormRemind";
            this.Text = "提醒管理";
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
            ((System.ComponentModel.ISupportInitialize)(this.remindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rhdbs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource remindBindingSource;
        private rhdbs rhdbs;
        private System.Windows.Forms.DateTimePicker dateTimeRemind;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.ComboBox cmbRemind;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCjjl;
        private System.Windows.Forms.TextBox txtXczx;
        private System.Windows.Forms.TextBox txtTbtx;
        private System.Windows.Forms.TextBox txtDhzx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn custnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remindflagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remindtimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSelName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbSelRmd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelLvl;
        private System.Windows.Forms.Label label5;
    }
}