namespace RenHeApp
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.picPlus = new System.Windows.Forms.PictureBox();
            this.pictMinus = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.提醒管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.人事管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.员工资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作日志查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录日志查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBoxMain = new System.Windows.Forms.GroupBox();
            this.btnCloseSubForm = new System.Windows.Forms.Button();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinus)).BeginInit();
            this.menuStripMain.SuspendLayout();
            this.grpBoxMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(106)))), ((int)(((byte)(134)))));
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.picPlus);
            this.panel1.Controls.Add(this.pictMinus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 40);
            this.panel1.TabIndex = 0;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.White;
            this.picClose.Image = ((System.Drawing.Image)(resources.GetObject("picClose.Image")));
            this.picClose.Location = new System.Drawing.Point(564, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(30, 30);
            this.picClose.TabIndex = 6;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // picPlus
            // 
            this.picPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picPlus.BackColor = System.Drawing.Color.White;
            this.picPlus.Image = ((System.Drawing.Image)(resources.GetObject("picPlus.Image")));
            this.picPlus.Location = new System.Drawing.Point(514, 5);
            this.picPlus.Name = "picPlus";
            this.picPlus.Size = new System.Drawing.Size(30, 30);
            this.picPlus.TabIndex = 5;
            this.picPlus.TabStop = false;
            this.picPlus.Click += new System.EventHandler(this.picPlus_Click);
            // 
            // pictMinus
            // 
            this.pictMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictMinus.BackColor = System.Drawing.Color.White;
            this.pictMinus.Image = ((System.Drawing.Image)(resources.GetObject("pictMinus.Image")));
            this.pictMinus.Location = new System.Drawing.Point(464, 5);
            this.pictMinus.Name = "pictMinus";
            this.pictMinus.Size = new System.Drawing.Size(30, 30);
            this.pictMinus.TabIndex = 4;
            this.pictMinus.TabStop = false;
            this.pictMinus.Click += new System.EventHandler(this.pictMinus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(106)))), ((int)(((byte)(134)))));
            this.label1.Font = new System.Drawing.Font("隶书", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "仁 和 整 形 售 后 管 理 系 统 v1.3";
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(208)))), ((int)(((byte)(214)))));
            this.menuStripMain.Font = new System.Drawing.Font("仿宋", 13F);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.提醒管理ToolStripMenuItem,
            this.客户管理ToolStripMenuItem,
            this.人事管理ToolStripMenuItem,
            this.系统设置ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 40);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.menuStripMain.Size = new System.Drawing.Size(613, 30);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "主菜单";
            // 
            // 提醒管理ToolStripMenuItem
            // 
            this.提醒管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem});
            this.提醒管理ToolStripMenuItem.Name = "提醒管理ToolStripMenuItem";
            this.提醒管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.提醒管理ToolStripMenuItem.Text = "提醒信息";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.管理ToolStripMenuItem.Text = "提醒管理";
            this.管理ToolStripMenuItem.Click += new System.EventHandler(this.管理ToolStripMenuItem_Click);
            // 
            // 客户管理ToolStripMenuItem
            // 
            this.客户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户查询ToolStripMenuItem});
            this.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem";
            this.客户管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 28);
            this.客户管理ToolStripMenuItem.Text = "客户资料";
            // 
            // 客户查询ToolStripMenuItem
            // 
            this.客户查询ToolStripMenuItem.Name = "客户查询ToolStripMenuItem";
            this.客户查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.客户查询ToolStripMenuItem.Text = "客户管理";
            this.客户查询ToolStripMenuItem.Click += new System.EventHandler(this.客户查询ToolStripMenuItem_Click);
            // 
            // 人事管理ToolStripMenuItem
            // 
            this.人事管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工资料ToolStripMenuItem});
            this.人事管理ToolStripMenuItem.Name = "人事管理ToolStripMenuItem";
            this.人事管理ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.人事管理ToolStripMenuItem.Text = "用户";
            // 
            // 员工资料ToolStripMenuItem
            // 
            this.员工资料ToolStripMenuItem.Name = "员工资料ToolStripMenuItem";
            this.员工资料ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.员工资料ToolStripMenuItem.Text = "用户管理";
            this.员工资料ToolStripMenuItem.Click += new System.EventHandler(this.员工资料ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作日志查询ToolStripMenuItem,
            this.登录日志查询ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(56, 28);
            this.系统设置ToolStripMenuItem.Text = "系统";
            // 
            // 操作日志查询ToolStripMenuItem
            // 
            this.操作日志查询ToolStripMenuItem.Name = "操作日志查询ToolStripMenuItem";
            this.操作日志查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.操作日志查询ToolStripMenuItem.Text = "密码修改";
            this.操作日志查询ToolStripMenuItem.Click += new System.EventHandler(this.操作日志查询ToolStripMenuItem_Click);
            // 
            // 登录日志查询ToolStripMenuItem
            // 
            this.登录日志查询ToolStripMenuItem.Name = "登录日志查询ToolStripMenuItem";
            this.登录日志查询ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.登录日志查询ToolStripMenuItem.Text = "日志查询";
            // 
            // grpBoxMain
            // 
            this.grpBoxMain.Controls.Add(this.btnCloseSubForm);
            this.grpBoxMain.Controls.Add(this.tabMain);
            this.grpBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxMain.Location = new System.Drawing.Point(0, 70);
            this.grpBoxMain.Name = "grpBoxMain";
            this.grpBoxMain.Size = new System.Drawing.Size(613, 314);
            this.grpBoxMain.TabIndex = 4;
            this.grpBoxMain.TabStop = false;
            // 
            // btnCloseSubForm
            // 
            this.btnCloseSubForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSubForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseSubForm.Location = new System.Drawing.Point(519, 19);
            this.btnCloseSubForm.Name = "btnCloseSubForm";
            this.btnCloseSubForm.Size = new System.Drawing.Size(88, 23);
            this.btnCloseSubForm.TabIndex = 4;
            this.btnCloseSubForm.Text = "关闭当前页";
            this.btnCloseSubForm.UseVisualStyleBackColor = true;
            this.btnCloseSubForm.Click += new System.EventHandler(this.btnCloseSubForm_Click);
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabMain.Controls.Add(this.tabPageMain);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ItemSize = new System.Drawing.Size(50, 20);
            this.tabMain.Location = new System.Drawing.Point(3, 19);
            this.tabMain.Margin = new System.Windows.Forms.Padding(1);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Drawing.Point(0, 0);
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(607, 292);
            this.tabMain.TabIndex = 2;
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackColor = System.Drawing.Color.White;
            this.tabPageMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageMain.BackgroundImage")));
            this.tabPageMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.tabPageMain.Location = new System.Drawing.Point(4, 24);
            this.tabPageMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Size = new System.Drawing.Size(599, 264);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "主页面";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(613, 384);
            this.Controls.Add(this.grpBoxMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictMinus)).EndInit();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.grpBoxMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem 提醒管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 人事管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 员工资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 操作日志查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录日志查询ToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBoxMain;
        private System.Windows.Forms.Button btnCloseSubForm;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictMinus;
        private System.Windows.Forms.PictureBox picPlus;
        private System.Windows.Forms.PictureBox picClose;

    }
}

