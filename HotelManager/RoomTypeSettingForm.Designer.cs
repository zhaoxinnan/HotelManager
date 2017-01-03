namespace HotelManager
{
    partial class RoomTypeSettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomTypeSettingForm));
            this.tspRoomSet = new System.Windows.Forms.ToolStrip();
            this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbtnModify = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDel = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSave = new System.Windows.Forms.ToolStripButton();
            this.tsbtnCancle = new System.Windows.Forms.ToolStripButton();
            this.tsbtnExit = new System.Windows.Forms.ToolStripButton();
            this.grpQuery = new System.Windows.Forms.GroupBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.dgvRoom = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tspRoomSet.SuspendLayout();
            this.grpQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.tspRoomSet.Size = new System.Drawing.Size(541, 38);
            this.tspRoomSet.TabIndex = 0;
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
            // grpQuery
            // 
            this.grpQuery.Controls.Add(this.btnQuery);
            this.grpQuery.Controls.Add(this.txtRoomNumber);
            this.grpQuery.Controls.Add(this.lblRoomNumber);
            this.grpQuery.Location = new System.Drawing.Point(0, 41);
            this.grpQuery.Name = "grpQuery";
            this.grpQuery.Size = new System.Drawing.Size(529, 45);
            this.grpQuery.TabIndex = 1;
            this.grpQuery.TabStop = false;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(100, 16);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(43, 13);
            this.lblRoomNumber.TabIndex = 0;
            this.lblRoomNumber.Text = "房间号";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(150, 16);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(197, 20);
            this.txtRoomNumber.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(353, 14);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // dgvRoom
            // 
            this.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRoom.Location = new System.Drawing.Point(13, 93);
            this.dgvRoom.Name = "dgvRoom";
            this.dgvRoom.Size = new System.Drawing.Size(516, 165);
            this.dgvRoom.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 114);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "类型名称";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "价格";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "加床价格";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "备注";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(188, 21);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(93, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(285, 21);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(381, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "是否可以加床";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // RoomTypeSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRoom);
            this.Controls.Add(this.grpQuery);
            this.Controls.Add(this.tspRoomSet);
            this.Name = "RoomTypeSettingForm";
            this.Text = "【客房类型设置】";
            this.Load += new System.EventHandler(this.RoomTypeSettingForm_Load);
            this.tspRoomSet.ResumeLayout(false);
            this.tspRoomSet.PerformLayout();
            this.grpQuery.ResumeLayout(false);
            this.grpQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoom)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpQuery;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtRoomNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.DataGridView dgvRoom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}