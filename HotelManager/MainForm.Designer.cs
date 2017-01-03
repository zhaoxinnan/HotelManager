namespace HotelManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmiBaseSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiManageBusiness = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbRoomType = new System.Windows.Forms.ToolStripButton();
            this.tsbRoomSet = new System.Windows.Forms.ToolStripButton();
            this.tsbBusiness = new System.Windows.Forms.ToolStripButton();
            this.tsbUserManager = new System.Windows.Forms.ToolStripButton();
            this.mnuMain.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBaseSetting,
            this.tsmiManageBusiness,
            this.tsmiUserManage,
            this.tsmiExit});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(657, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "menuStrip1";
            // 
            // tsmiBaseSetting
            // 
            this.tsmiBaseSetting.Name = "tsmiBaseSetting";
            this.tsmiBaseSetting.Size = new System.Drawing.Size(67, 20);
            this.tsmiBaseSetting.Text = "基础设置";
            // 
            // tsmiManageBusiness
            // 
            this.tsmiManageBusiness.Name = "tsmiManageBusiness";
            this.tsmiManageBusiness.Size = new System.Drawing.Size(67, 20);
            this.tsmiManageBusiness.Text = "业务管理";
            // 
            // tsmiUserManage
            // 
            this.tsmiUserManage.Name = "tsmiUserManage";
            this.tsmiUserManage.Size = new System.Drawing.Size(67, 20);
            this.tsmiUserManage.Text = "用户管理";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(67, 20);
            this.tsmiExit.Text = "退出系统";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRoomType,
            this.tsbRoomSet,
            this.tsbBusiness,
            this.tsbUserManager});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbRoomType
            // 
            this.tsbRoomType.Image = ((System.Drawing.Image)(resources.GetObject("tsbRoomType.Image")));
            this.tsbRoomType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoomType.Name = "tsbRoomType";
            this.tsbRoomType.Size = new System.Drawing.Size(99, 22);
            this.tsbRoomType.Text = "客房类型设置";
            // 
            // tsbRoomSet
            // 
            this.tsbRoomSet.Image = ((System.Drawing.Image)(resources.GetObject("tsbRoomSet.Image")));
            this.tsbRoomSet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRoomSet.Name = "tsbRoomSet";
            this.tsbRoomSet.Size = new System.Drawing.Size(99, 22);
            this.tsbRoomSet.Text = "客房信息设置";
            // 
            // tsbBusiness
            // 
            this.tsbBusiness.Image = ((System.Drawing.Image)(resources.GetObject("tsbBusiness.Image")));
            this.tsbBusiness.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBusiness.Name = "tsbBusiness";
            this.tsbBusiness.Size = new System.Drawing.Size(75, 22);
            this.tsbBusiness.Text = "业务管理";
            // 
            // tsbUserManager
            // 
            this.tsbUserManager.Image = ((System.Drawing.Image)(resources.GetObject("tsbUserManager.Image")));
            this.tsbUserManager.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUserManager.Name = "tsbUserManager";
            this.tsbUserManager.Size = new System.Drawing.Size(75, 22);
            this.tsbUserManager.Text = "用户管理";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 337);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.mnuMain);
            this.MainMenuStrip = this.mnuMain;
            this.Name = "MainForm";
            this.Text = "【酒店管理系统】";
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiBaseSetting;
        private System.Windows.Forms.ToolStripMenuItem tsmiManageBusiness;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbRoomType;
        private System.Windows.Forms.ToolStripButton tsbRoomSet;
        private System.Windows.Forms.ToolStripButton tsbBusiness;
        private System.Windows.Forms.ToolStripButton tsbUserManager;
    }
}