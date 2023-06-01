namespace Bai4_Trang60
{
    partial class Form1
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtKetQua = new System.Windows.Forms.TextBox();
			this.txtB = new System.Windows.Forms.TextBox();
			this.txtA = new System.Windows.Forms.TextBox();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.grbPhepTinh = new System.Windows.Forms.GroupBox();
			this.rdoNhan = new System.Windows.Forms.RadioButton();
			this.rdoTru = new System.Windows.Forms.RadioButton();
			this.rdoChia = new System.Windows.Forms.RadioButton();
			this.rdoCong = new System.Windows.Forms.RadioButton();
			this.grbSoSanh = new System.Windows.Forms.GroupBox();
			this.lblMin = new System.Windows.Forms.Label();
			this.lblMax = new System.Windows.Forms.Label();
			this.chkMin = new System.Windows.Forms.CheckBox();
			this.chkMax = new System.Windows.Forms.CheckBox();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.grbPhepTinh.SuspendLayout();
			this.grbSoSanh.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.txtKetQua);
			this.groupBox1.Controls.Add(this.txtB);
			this.groupBox1.Controls.Add(this.txtA);
			this.groupBox1.Location = new System.Drawing.Point(31, 22);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(744, 159);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(53, 111);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Kết quả:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(53, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 25);
			this.label2.TabIndex = 4;
			this.label2.Text = "Nhập B:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(53, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 25);
			this.label1.TabIndex = 3;
			this.label1.Text = "Nhập A:";
			// 
			// txtKetQua
			// 
			this.txtKetQua.Enabled = false;
			this.txtKetQua.Location = new System.Drawing.Point(192, 115);
			this.txtKetQua.Name = "txtKetQua";
			this.txtKetQua.ReadOnly = true;
			this.txtKetQua.Size = new System.Drawing.Size(524, 22);
			this.txtKetQua.TabIndex = 2;
			// 
			// txtB
			// 
			this.txtB.Location = new System.Drawing.Point(192, 71);
			this.txtB.Name = "txtB";
			this.txtB.Size = new System.Drawing.Size(524, 22);
			this.txtB.TabIndex = 1;
			this.txtB.Enter += new System.EventHandler(this.txtA_Enter);
			this.txtB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
			this.txtB.Leave += new System.EventHandler(this.txtA_Leave);
			// 
			// txtA
			// 
			this.txtA.Location = new System.Drawing.Point(192, 30);
			this.txtA.Name = "txtA";
			this.txtA.Size = new System.Drawing.Size(524, 22);
			this.txtA.TabIndex = 0;
			this.txtA.Enter += new System.EventHandler(this.txtA_Enter);
			this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
			this.txtA.Leave += new System.EventHandler(this.txtA_Leave);
			// 
			// grbPhepTinh
			// 
			this.grbPhepTinh.Controls.Add(this.rdoNhan);
			this.grbPhepTinh.Controls.Add(this.rdoTru);
			this.grbPhepTinh.Controls.Add(this.rdoChia);
			this.grbPhepTinh.Controls.Add(this.rdoCong);
			this.grbPhepTinh.Enabled = false;
			this.grbPhepTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbPhepTinh.Location = new System.Drawing.Point(32, 201);
			this.grbPhepTinh.Name = "grbPhepTinh";
			this.grbPhepTinh.Size = new System.Drawing.Size(348, 147);
			this.grbPhepTinh.TabIndex = 1;
			this.grbPhepTinh.TabStop = false;
			this.grbPhepTinh.Text = "Phép Tính";
			// 
			// rdoNhan
			// 
			this.rdoNhan.AutoSize = true;
			this.rdoNhan.Location = new System.Drawing.Point(26, 76);
			this.rdoNhan.Name = "rdoNhan";
			this.rdoNhan.Size = new System.Drawing.Size(84, 29);
			this.rdoNhan.TabIndex = 3;
			this.rdoNhan.Text = "Nhân";
			this.rdoNhan.UseVisualStyleBackColor = true;
			this.rdoNhan.CheckedChanged += new System.EventHandler(this.rdoCong_CheckedChanged);
			// 
			// rdoTru
			// 
			this.rdoTru.AutoSize = true;
			this.rdoTru.Location = new System.Drawing.Point(191, 41);
			this.rdoTru.Name = "rdoTru";
			this.rdoTru.Size = new System.Drawing.Size(66, 29);
			this.rdoTru.TabIndex = 2;
			this.rdoTru.Text = "Trừ";
			this.rdoTru.UseVisualStyleBackColor = true;
			this.rdoTru.CheckedChanged += new System.EventHandler(this.rdoCong_CheckedChanged);
			// 
			// rdoChia
			// 
			this.rdoChia.AutoSize = true;
			this.rdoChia.Location = new System.Drawing.Point(191, 76);
			this.rdoChia.Name = "rdoChia";
			this.rdoChia.Size = new System.Drawing.Size(78, 29);
			this.rdoChia.TabIndex = 1;
			this.rdoChia.Text = "Chia";
			this.rdoChia.UseVisualStyleBackColor = true;
			this.rdoChia.CheckedChanged += new System.EventHandler(this.rdoCong_CheckedChanged);
			// 
			// rdoCong
			// 
			this.rdoCong.AutoSize = true;
			this.rdoCong.Location = new System.Drawing.Point(26, 41);
			this.rdoCong.Name = "rdoCong";
			this.rdoCong.Size = new System.Drawing.Size(85, 29);
			this.rdoCong.TabIndex = 0;
			this.rdoCong.Text = "Cộng";
			this.rdoCong.UseVisualStyleBackColor = true;
			this.rdoCong.CheckedChanged += new System.EventHandler(this.rdoCong_CheckedChanged);
			// 
			// grbSoSanh
			// 
			this.grbSoSanh.Controls.Add(this.lblMin);
			this.grbSoSanh.Controls.Add(this.lblMax);
			this.grbSoSanh.Controls.Add(this.chkMin);
			this.grbSoSanh.Controls.Add(this.chkMax);
			this.grbSoSanh.Enabled = false;
			this.grbSoSanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.grbSoSanh.Location = new System.Drawing.Point(427, 201);
			this.grbSoSanh.Name = "grbSoSanh";
			this.grbSoSanh.Size = new System.Drawing.Size(348, 147);
			this.grbSoSanh.TabIndex = 2;
			this.grbSoSanh.TabStop = false;
			this.grbSoSanh.Text = "So Sánh";
			// 
			// lblMin
			// 
			this.lblMin.AutoSize = true;
			this.lblMin.Location = new System.Drawing.Point(142, 78);
			this.lblMin.Name = "lblMin";
			this.lblMin.Size = new System.Drawing.Size(0, 25);
			this.lblMin.TabIndex = 3;
			// 
			// lblMax
			// 
			this.lblMax.AutoSize = true;
			this.lblMax.Location = new System.Drawing.Point(142, 42);
			this.lblMax.Name = "lblMax";
			this.lblMax.Size = new System.Drawing.Size(0, 25);
			this.lblMax.TabIndex = 2;
			// 
			// chkMin
			// 
			this.chkMin.AutoSize = true;
			this.chkMin.Location = new System.Drawing.Point(36, 77);
			this.chkMin.Name = "chkMin";
			this.chkMin.Size = new System.Drawing.Size(94, 29);
			this.chkMin.TabIndex = 1;
			this.chkMin.Text = "Min = ";
			this.chkMin.UseVisualStyleBackColor = true;
			this.chkMin.CheckedChanged += new System.EventHandler(this.chkMin_CheckedChanged);
			// 
			// chkMax
			// 
			this.chkMax.AutoSize = true;
			this.chkMax.Location = new System.Drawing.Point(36, 41);
			this.chkMax.Name = "chkMax";
			this.chkMax.Size = new System.Drawing.Size(100, 29);
			this.chkMax.TabIndex = 0;
			this.chkMax.Text = "Max = ";
			this.chkMax.UseVisualStyleBackColor = true;
			this.chkMax.CheckedChanged += new System.EventHandler(this.chkMax_CheckedChanged);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(32, 380);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(347, 45);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "&Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(427, 380);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(348, 45);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "&Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.grbSoSanh);
			this.Controls.Add(this.grbPhepTinh);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài tập 4 trang 60";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.grbPhepTinh.ResumeLayout(false);
			this.grbPhepTinh.PerformLayout();
			this.grbSoSanh.ResumeLayout(false);
			this.grbSoSanh.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbPhepTinh;
        private System.Windows.Forms.RadioButton rdoNhan;
        private System.Windows.Forms.RadioButton rdoTru;
        private System.Windows.Forms.RadioButton rdoChia;
        private System.Windows.Forms.RadioButton rdoCong;
        private System.Windows.Forms.GroupBox grbSoSanh;
        private System.Windows.Forms.CheckBox chkMax;
        private System.Windows.Forms.CheckBox chkMin;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
    }
}

