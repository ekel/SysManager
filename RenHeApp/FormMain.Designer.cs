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
            this.menuStripMain.SuspendLayout();
            this.grpBoxMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.AutoSize = false;
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.提醒管理ToolStripMenuItem,
            this.客户管理ToolStripMenuItem,
            this.人事管理ToolStripMenuItem,
            this.系统设置ToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.menuStripMain.Size = new System.Drawing.Size(613, 30);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "主菜单";
            // 
            // 提醒管理ToolStripMenuItem
            // 
            this.提醒管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理ToolStripMenuItem});
            this.提醒管理ToolStripMenuItem.Name = "提醒管理ToolStripMenuItem";
            this.提醒管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.提醒管理ToolStripMenuItem.Text = "提醒信息";
            // 
            // 管理ToolStripMenuItem
            // 
            this.管理ToolStripMenuItem.Name = "管理ToolStripMenuItem";
            this.管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.管理ToolStripMenuItem.Text = "提醒管理";
            this.管理ToolStripMenuItem.Click += new System.EventHandler(this.管理ToolStripMenuItem_Click);
            // 
            // 客户管理ToolStripMenuItem
            // 
            this.客户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客户查询ToolStripMenuItem});
            this.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem";
            this.客户管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 28);
            this.客户管理ToolStripMenuItem.Text = "客户资料";
            // 
            // 客户查询ToolStripMenuItem
            // 
            this.客户查询ToolStripMenuItem.Name = "客户查询ToolStripMenuItem";
            this.客户查询ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.客户查询ToolStripMenuItem.Text = "客户管理";
            this.客户查询ToolStripMenuItem.Click += new System.EventHandler(this.客户查询ToolStripMenuItem_Click);
            // 
            // 人事管理ToolStripMenuItem
            // 
            this.人事管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.员工资料ToolStripMenuItem});
            this.人事管理ToolStripMenuItem.Name = "人事管理ToolStripMenuItem";
            this.人事管理ToolStripMenuItem.Size = new System.Drawing.Size(44, 28);
            this.人事管理ToolStripMenuItem.Text = "用户";
            // 
            // 员工资料ToolStripMenuItem
            // 
            this.员工资料ToolStripMenuItem.Name = "员工资料ToolStripMenuItem";
            this.员工资料ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.员工资料ToolStripMenuItem.Text = "用户管理";
            this.员工资料ToolStripMenuItem.Click += new System.EventHandler(this.员工资料ToolStripMenuItem_Click);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作日志查询ToolStripMenuItem,
            this.登录日志查询ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(44, 28);
            this.系统设置ToolStripMenuItem.Text = "系统";
            // 
            // 操作日志查询ToolStripMenuItem
            // 
            this.操作日志查询ToolStripMenuItem.Name = "操作日志查询ToolStripMenuItem";
            this.操作日志查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.操作日志查询ToolStripMenuItem.Text = "密码修改";
            this.操作日志查询ToolStripMenuItem.Click += new System.EventHandler(this.操作日志查询ToolStripMenuItem_Click);
            // 
            // 登录日志查询ToolStripMenuItem
            // 
            this.登录日志查询ToolStripMenuItem.Name = "登录日志查询ToolStripMenuItem";
            this.登录日志查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.登录日志查询ToolStripMenuItem.Text = "日志查询";
            // 
            // grpBoxMain
            // 
            this.grpBoxMain.Controls.Add(this.btnCloseSubForm);
            this.grpBoxMain.Controls.Add(this.tabMain);
            this.grpBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxMain.Location = new System.Drawing.Point(0, 30);
            this.grpBoxMain.Name = "grpBoxMain";
            this.grpBoxMain.Size = new System.Drawing.Size(613, 354);
            this.grpBoxMain.TabIndex = 3;
            this.grpBoxMain.TabStop = false;
            // 
            // btnCloseSubForm
            // 
            this.btnCloseSubForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseSubForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCloseSubForm.Location = new System.Drawing.Point(519, 18);
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
            this.tabMain.Size = new System.Drawing.Size(607, 332);
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
            this.tabPageMain.Size = new System.Drawing.Size(599, 304);
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
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "仁和整形售后管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.grpBoxMain.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.Button btnCloseSubForm;
    }
}

