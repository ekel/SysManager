namespace RenHeApp
{
    partial class SubFormUser
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
			this.rhdbs = new RenHeApp.rhdbs();
			this.labID = new System.Windows.Forms.Label();
			this.labNote = new System.Windows.Forms.Label();
			this.labRole = new System.Windows.Forms.Label();
			this.labPswd = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.txtPwd = new System.Windows.Forms.TextBox();
			this.radioBtn1 = new System.Windows.Forms.RadioButton();
			this.radioBtn2 = new System.Windows.Forms.RadioButton();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.useridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.userinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.labMsg = new System.Windows.Forms.Label();
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
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			this.grpBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rhdbs)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.userinfoBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.SplitterDistance = 70;
			// 
			// splitContainer2
			// 
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.dataGridView);
			this.splitContainer2.Size = new System.Drawing.Size(1186, 447);
			this.splitContainer2.SplitterDistance = 379;
			// 
			// grpBox1
			// 
			this.grpBox1.Size = new System.Drawing.Size(1186, 70);
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
			this.splitContainer3.SplitterDistance = 454;
			// 
			// grpBox2
			// 
			this.grpBox2.Controls.Add(this.labMsg);
			this.grpBox2.Controls.Add(this.txtNote);
			this.grpBox2.Controls.Add(this.radioBtn2);
			this.grpBox2.Controls.Add(this.radioBtn1);
			this.grpBox2.Controls.Add(this.txtPwd);
			this.grpBox2.Controls.Add(this.txtUser);
			this.grpBox2.Controls.Add(this.labPswd);
			this.grpBox2.Controls.Add(this.labRole);
			this.grpBox2.Controls.Add(this.labNote);
			this.grpBox2.Controls.Add(this.labID);
			this.grpBox2.Size = new System.Drawing.Size(1186, 454);
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(939, 16);
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(1089, 16);
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// rhdbs
			// 
			this.rhdbs.DataSetName = "rhdbs";
			this.rhdbs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// labID
			// 
			this.labID.AutoSize = true;
			this.labID.Location = new System.Drawing.Point(40, 37);
			this.labID.Name = "labID";
			this.labID.Size = new System.Drawing.Size(41, 12);
			this.labID.TabIndex = 0;
			this.labID.Text = "用户名";
			// 
			// labNote
			// 
			this.labNote.AutoSize = true;
			this.labNote.Location = new System.Drawing.Point(40, 170);
			this.labNote.Name = "labNote";
			this.labNote.Size = new System.Drawing.Size(29, 12);
			this.labNote.TabIndex = 1;
			this.labNote.Text = "备注";
			// 
			// labRole
			// 
			this.labRole.AutoSize = true;
			this.labRole.Location = new System.Drawing.Point(40, 112);
			this.labRole.Name = "labRole";
			this.labRole.Size = new System.Drawing.Size(29, 12);
			this.labRole.TabIndex = 2;
			this.labRole.Text = "权限";
			// 
			// labPswd
			// 
			this.labPswd.AutoSize = true;
			this.labPswd.Location = new System.Drawing.Point(40, 77);
			this.labPswd.Name = "labPswd";
			this.labPswd.Size = new System.Drawing.Size(29, 12);
			this.labPswd.TabIndex = 3;
			this.labPswd.Text = "密码";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(100, 37);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(127, 21);
			this.txtUser.TabIndex = 5;
			this.txtUser.MouseLeave += new System.EventHandler(this.txtUser_MouseLeave);
			// 
			// txtPwd
			// 
			this.txtPwd.Location = new System.Drawing.Point(100, 72);
			this.txtPwd.Name = "txtPwd";
			this.txtPwd.PasswordChar = '*';
			this.txtPwd.Size = new System.Drawing.Size(127, 21);
			this.txtPwd.TabIndex = 6;
			// 
			// radioBtn1
			// 
			this.radioBtn1.AutoSize = true;
			this.radioBtn1.Location = new System.Drawing.Point(100, 112);
			this.radioBtn1.Name = "radioBtn1";
			this.radioBtn1.Size = new System.Drawing.Size(59, 16);
			this.radioBtn1.TabIndex = 8;
			this.radioBtn1.Text = "管理员";
			this.radioBtn1.UseVisualStyleBackColor = true;
			// 
			// radioBtn2
			// 
			this.radioBtn2.AutoSize = true;
			this.radioBtn2.Checked = true;
			this.radioBtn2.Location = new System.Drawing.Point(100, 134);
			this.radioBtn2.Name = "radioBtn2";
			this.radioBtn2.Size = new System.Drawing.Size(71, 16);
			this.radioBtn2.TabIndex = 9;
			this.radioBtn2.TabStop = true;
			this.radioBtn2.Text = "非管理员";
			this.radioBtn2.UseVisualStyleBackColor = true;
			// 
			// txtNote
			// 
			this.txtNote.Location = new System.Drawing.Point(100, 167);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(241, 113);
			this.txtNote.TabIndex = 10;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.AutoGenerateColumns = false;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.useridDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn});
			this.dataGridView.DataSource = this.userinfoBindingSource;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.GridColor = System.Drawing.Color.White;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView.Size = new System.Drawing.Size(1186, 379);
			this.dataGridView.TabIndex = 3;
			// 
			// useridDataGridViewTextBoxColumn
			// 
			this.useridDataGridViewTextBoxColumn.DataPropertyName = "user_id";
			this.useridDataGridViewTextBoxColumn.HeaderText = "用户名";
			this.useridDataGridViewTextBoxColumn.Name = "useridDataGridViewTextBoxColumn";
			this.useridDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// roleDataGridViewTextBoxColumn
			// 
			this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
			this.roleDataGridViewTextBoxColumn.HeaderText = "权限";
			this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
			this.roleDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// noteDataGridViewTextBoxColumn
			// 
			this.noteDataGridViewTextBoxColumn.DataPropertyName = "note";
			this.noteDataGridViewTextBoxColumn.HeaderText = "备注";
			this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
			this.noteDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// userinfoBindingSource
			// 
			this.userinfoBindingSource.DataMember = "user_info";
			this.userinfoBindingSource.DataSource = this.rhdbs;
			// 
			// labMsg
			// 
			this.labMsg.AutoSize = true;
			this.labMsg.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.labMsg.Location = new System.Drawing.Point(248, 46);
			this.labMsg.Name = "labMsg";
			this.labMsg.Size = new System.Drawing.Size(0, 12);
			this.labMsg.TabIndex = 11;
			// 
			// SubFormUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1200, 550);
			this.Name = "SubFormUser";
			this.Text = "用户管理";
			this.Load += new System.EventHandler(this.SubFormUser_Load);
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
			this.tabPage2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.grpBox2.ResumeLayout(false);
			this.grpBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rhdbs)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.userinfoBindingSource)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private rhdbs rhdbs;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labPswd;
        private System.Windows.Forms.Label labRole;
        private System.Windows.Forms.Label labNote;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.RadioButton radioBtn2;
        private System.Windows.Forms.RadioButton radioBtn1;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtNote;
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource userinfoBindingSource;
        private System.Windows.Forms.Label labMsg;
        private System.Windows.Forms.DataGridViewTextBoxColumn useridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    }
}