namespace HotelManager
{
    partial class UserManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserManagerForm));
            this.tspRoomSet = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModify = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancle = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tspRoomSet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tspRoomSet
            // 
            this.tspRoomSet.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.tsbtnModify,
            this.tsbtnDel,
            this.tsbtnSave,
            this.tsbtnCancle,
            this.tsbtnExit});
            this.tspRoomSet.Location = new System.Drawing.Point(0, 0);
            this.tspRoomSet.Name = "tspRoomSet";
            this.tspRoomSet.Size = new System.Drawing.Size(610, 38);
            this.tspRoomSet.TabIndex = 6;
            this.tspRoomSet.Text = "toolStrip1";
            // 
            // tsbtnAdd
            // 
            this.tsbtnAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnAdd.Image")));
            this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnAdd.Name = "tsbtnAdd";
            this.tsbtnAdd.Size = new System.Drawing.Size(35, 35);
            this.tsbtnAdd.Text = "新增";
            this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnModify
            // 
            this.tsbtnModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnModify.Image")));
            this.tsbtnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnModify.Name = "tsbtnModify";
            this.tsbtnModify.Size = new System.Drawing.Size(35, 35);
            this.tsbtnModify.Text = "修改";
            this.tsbtnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnDel
            // 
            this.tsbtnDel.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnDel.Image")));
            this.tsbtnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDel.Name = "tsbtnDel";
            this.tsbtnDel.Size = new System.Drawing.Size(35, 35);
            this.tsbtnDel.Text = "删除";
            this.tsbtnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnSave
            // 
            this.tsbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSave.Image")));
            this.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSave.Name = "tsbtnSave";
            this.tsbtnSave.Size = new System.Drawing.Size(35, 35);
            this.tsbtnSave.Text = "保存";
            this.tsbtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnCancle
            // 
            this.tsbtnCancle.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCancle.Image")));
            this.tsbtnCancle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCancle.Name = "tsbtnCancle";
            this.tsbtnCancle.Size = new System.Drawing.Size(35, 35);
            this.tsbtnCancle.Text = "取消";
            this.tsbtnCancle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tsbtnExit
            // 
            this.tsbtnExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnExit.Image")));
            this.tsbtnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnExit.Name = "tsbtnExit";
            this.tsbtnExit.Size = new System.Drawing.Size(35, 35);
            this.tsbtnExit.Text = "退出";
            this.tsbtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(585, 149);
            this.dataGridView1.TabIndex = 7;
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 344);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tspRoomSet);
            this.Name = "UserManagerForm";
            this.Text = "UserManagerForm";
            this.tspRoomSet.ResumeLayout(false);
            this.tspRoomSet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tspRoomSet;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripButton tsbtnModify;
        private System.Windows.Forms.ToolStripButton tsbtnDel;
        private System.Windows.Forms.ToolStripButton tsbtnSave;
        private System.Windows.Forms.ToolStripButton tsbtnCancle;
        private System.Windows.Forms.ToolStripButton tsbtnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}