namespace HotelManager
{
    partial class LoginForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtLoginId = new System.Windows.Forms.TextBox();
            this.txtLogInPwd = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(151, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "用户名：";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(163, 149);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(43, 13);
            this.lblPwd.TabIndex = 1;
            this.lblPwd.Text = "密码：";
            // 
            // txtLoginId
            // 
            this.txtLoginId.Location = new System.Drawing.Point(204, 86);
            this.txtLoginId.Name = "txtLoginId";
            this.txtLoginId.Size = new System.Drawing.Size(236, 20);
            this.txtLoginId.TabIndex = 2;
            // 
            // txtLogInPwd
            // 
            this.txtLogInPwd.Location = new System.Drawing.Point(204, 146);
            this.txtLogInPwd.Name = "txtLogInPwd";
            this.txtLogInPwd.PasswordChar = '(';
            this.txtLogInPwd.Size = new System.Drawing.Size(236, 20);
            this.txtLogInPwd.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(324, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(202, 213);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 314);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtLogInPwd);
            this.Controls.Add(this.txtLoginId);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.lblName);
            this.Name = "LoginForm";
            this.Text = "登录";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtLoginId;
        private System.Windows.Forms.TextBox txtLogInPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
    }
}

