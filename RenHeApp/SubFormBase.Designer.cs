namespace RenHeApp
{
    public partial class SubFormBase
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
            this.tabSub = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnSel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUpt = new System.Windows.Forms.Button();
            this.btnDtl = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.grpBox2 = new System.Windows.Forms.GroupBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabSub.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSub
            // 
            this.tabSub.Controls.Add(this.tabPage1);
            this.tabSub.Controls.Add(this.tabPage2);
            this.tabSub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSub.ItemSize = new System.Drawing.Size(40, 15);
            this.tabSub.Location = new System.Drawing.Point(0, 0);
            this.tabSub.Name = "tabSub";
            this.tabSub.SelectedIndex = 0;
            this.tabSub.Size = new System.Drawing.Size(1200, 550);
            this.tabSub.TabIndex = 37;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 19);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1192, 527);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "总览";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1186, 521);
            this.splitContainer1.SplitterDistance = 72;
            this.splitContainer1.TabIndex = 1;
            // 
            // grpBox1
            // 
            this.grpBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox1.Location = new System.Drawing.Point(0, 0);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(1186, 72);
            this.grpBox1.TabIndex = 2;
            this.grpBox1.TabStop = false;
            this.grpBox1.Text = "查询条件";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.btnSel);
            this.splitContainer2.Panel2.Controls.Add(this.btnAdd);
            this.splitContainer2.Panel2.Controls.Add(this.btnDel);
            this.splitContainer2.Panel2.Controls.Add(this.btnUpt);
            this.splitContainer2.Panel2.Controls.Add(this.btnDtl);
            this.splitContainer2.Size = new System.Drawing.Size(1186, 445);
            this.splitContainer2.SplitterDistance = 352;
            this.splitContainer2.TabIndex = 0;
            // 
            // btnSel
            // 
            this.btnSel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSel.Location = new System.Drawing.Point(779, 42);
            this.btnSel.Name = "btnSel";
            this.btnSel.Size = new System.Drawing.Size(65, 34);
            this.btnSel.TabIndex = 43;
            this.btnSel.Text = "查询";
            this.btnSel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(879, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 34);
            this.btnAdd.TabIndex = 42;
            this.btnAdd.Text = "添加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDel.Location = new System.Drawing.Point(979, 42);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(65, 34);
            this.btnDel.TabIndex = 44;
            this.btnDel.Text = "删除";
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnUpt
            // 
            this.btnUpt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpt.Location = new System.Drawing.Point(1079, 42);
            this.btnUpt.Name = "btnUpt";
            this.btnUpt.Size = new System.Drawing.Size(65, 34);
            this.btnUpt.TabIndex = 45;
            this.btnUpt.Text = "修改";
            this.btnUpt.UseVisualStyleBackColor = true;
            // 
            // btnDtl
            // 
            this.btnDtl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDtl.Location = new System.Drawing.Point(40, 42);
            this.btnDtl.Name = "btnDtl";
            this.btnDtl.Size = new System.Drawing.Size(65, 34);
            this.btnDtl.TabIndex = 46;
            this.btnDtl.Text = "详细";
            this.btnDtl.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer3);
            this.tabPage2.Location = new System.Drawing.Point(4, 19);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1192, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.grpBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.btnOK);
            this.splitContainer3.Panel2.Controls.Add(this.btnCancel);
            this.splitContainer3.Size = new System.Drawing.Size(1186, 521);
            this.splitContainer3.SplitterDistance = 425;
            this.splitContainer3.TabIndex = 1;
            // 
            // grpBox2
            // 
            this.grpBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBox2.Location = new System.Drawing.Point(0, 0);
            this.grpBox2.Name = "grpBox2";
            this.grpBox2.Size = new System.Drawing.Size(1186, 425);
            this.grpBox2.TabIndex = 2;
            this.grpBox2.TabStop = false;
            this.grpBox2.Text = "详细内容";
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(939, 45);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(65, 34);
            this.btnOK.TabIndex = 38;
            this.btnOK.Text = "确定";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(1089, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(65, 34);
            this.btnCancel.TabIndex = 39;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SubFormBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 550);
            this.ControlBox = false;
            this.Controls.Add(this.tabSub);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubFormBase";
            this.tabSub.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        // 子窗体
        protected System.Windows.Forms.TabControl tabSub;

        // 页面1
        protected System.Windows.Forms.TabPage tabPage1;
        protected System.Windows.Forms.SplitContainer splitContainer1;
        protected System.Windows.Forms.SplitContainer splitContainer2;
        protected System.Windows.Forms.GroupBox grpBox1;
        protected System.Windows.Forms.Button btnSel;
        protected System.Windows.Forms.Button btnAdd;
        protected System.Windows.Forms.Button btnDel;
        protected System.Windows.Forms.Button btnUpt;
        protected System.Windows.Forms.Button btnDtl;
        // 页面2
        protected System.Windows.Forms.TabPage tabPage2;
        protected System.Windows.Forms.SplitContainer splitContainer3;
        protected System.Windows.Forms.GroupBox grpBox2;
        protected System.Windows.Forms.Button btnOK;
        protected System.Windows.Forms.Button btnCancel;
    }
}