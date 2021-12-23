
namespace TESTQLSV
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.txtDKT = new System.Windows.Forms.TextBox();
            this.txtDQT = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvQL = new System.Windows.Forms.DataGridView();
            this.clm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oPENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAVEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXCELToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtmax = new System.Windows.Forms.TextBox();
            this.btndiemmax = new System.Windows.Forms.Button();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.btndiemMIn = new System.Windows.Forms.Button();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.btndiemAvg = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQL)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(336, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Danh Sách Sinh Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.txtDKT);
            this.groupBox1.Controls.Add(this.txtDQT);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.txtHT);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(117, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 262);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(79, 219);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 37);
            this.btnluu.TabIndex = 3;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(255, 217);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 37);
            this.btnxoa.TabIndex = 3;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(255, 160);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 36);
            this.btnsua.TabIndex = 3;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(79, 160);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 36);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // txtDKT
            // 
            this.txtDKT.Location = new System.Drawing.Point(182, 115);
            this.txtDKT.Name = "txtDKT";
            this.txtDKT.Size = new System.Drawing.Size(148, 22);
            this.txtDKT.TabIndex = 4;
            // 
            // txtDQT
            // 
            this.txtDQT.Location = new System.Drawing.Point(182, 87);
            this.txtDQT.Name = "txtDQT";
            this.txtDQT.Size = new System.Drawing.Size(148, 22);
            this.txtDQT.TabIndex = 3;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(182, 59);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(148, 22);
            this.txtMSSV.TabIndex = 2;
            // 
            // txtHT
            // 
            this.txtHT.Location = new System.Drawing.Point(182, 34);
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(148, 22);
            this.txtHT.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(76, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "ĐKT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "ĐQT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "MSSV";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và Tên";
            // 
            // dgvQL
            // 
            this.dgvQL.AllowUserToAddRows = false;
            this.dgvQL.AllowUserToDeleteRows = false;
            this.dgvQL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQL.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm1,
            this.clm2,
            this.clm3,
            this.clm4,
            this.clm5,
            this.clm6});
            this.dgvQL.Location = new System.Drawing.Point(622, 100);
            this.dgvQL.Name = "dgvQL";
            this.dgvQL.ReadOnly = true;
            this.dgvQL.RowHeadersWidth = 51;
            this.dgvQL.RowTemplate.Height = 24;
            this.dgvQL.Size = new System.Drawing.Size(509, 262);
            this.dgvQL.TabIndex = 2;
            // 
            // clm1
            // 
            this.clm1.HeaderText = "STT";
            this.clm1.MinimumWidth = 6;
            this.clm1.Name = "clm1";
            this.clm1.ReadOnly = true;
            this.clm1.Width = 35;
            // 
            // clm2
            // 
            this.clm2.HeaderText = "Họ và Tên";
            this.clm2.MinimumWidth = 6;
            this.clm2.Name = "clm2";
            this.clm2.ReadOnly = true;
            this.clm2.Width = 125;
            // 
            // clm3
            // 
            this.clm3.HeaderText = "MSSV";
            this.clm3.MinimumWidth = 6;
            this.clm3.Name = "clm3";
            this.clm3.ReadOnly = true;
            this.clm3.Width = 40;
            // 
            // clm4
            // 
            this.clm4.HeaderText = "ĐQT";
            this.clm4.MinimumWidth = 6;
            this.clm4.Name = "clm4";
            this.clm4.ReadOnly = true;
            this.clm4.Width = 35;
            // 
            // clm5
            // 
            this.clm5.HeaderText = "ĐKT";
            this.clm5.MinimumWidth = 6;
            this.clm5.Name = "clm5";
            this.clm5.ReadOnly = true;
            this.clm5.Width = 35;
            // 
            // clm6
            // 
            this.clm6.HeaderText = "ĐTK";
            this.clm6.MinimumWidth = 6;
            this.clm6.Name = "clm6";
            this.clm6.ReadOnly = true;
            this.clm6.Width = 35;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nEWToolStripMenuItem,
            this.oPENToolStripMenuItem,
            this.sAVEToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // nEWToolStripMenuItem
            // 
            this.nEWToolStripMenuItem.Name = "nEWToolStripMenuItem";
            this.nEWToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.nEWToolStripMenuItem.Text = "NEW";
            this.nEWToolStripMenuItem.Click += new System.EventHandler(this.nEWToolStripMenuItem_Click);
            // 
            // oPENToolStripMenuItem
            // 
            this.oPENToolStripMenuItem.Name = "oPENToolStripMenuItem";
            this.oPENToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.oPENToolStripMenuItem.Text = "OPEN";
            this.oPENToolStripMenuItem.Click += new System.EventHandler(this.oPENToolStripMenuItem_Click);
            // 
            // sAVEToolStripMenuItem
            // 
            this.sAVEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eXCELToolStripMenuItem,
            this.tXTToolStripMenuItem});
            this.sAVEToolStripMenuItem.Name = "sAVEToolStripMenuItem";
            this.sAVEToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.sAVEToolStripMenuItem.Text = "SAVE";
            // 
            // eXCELToolStripMenuItem
            // 
            this.eXCELToolStripMenuItem.Name = "eXCELToolStripMenuItem";
            this.eXCELToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.eXCELToolStripMenuItem.Text = "EXCEL";
            this.eXCELToolStripMenuItem.Click += new System.EventHandler(this.eXCELToolStripMenuItem_Click);
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.tXTToolStripMenuItem.Text = "TXT";
            this.tXTToolStripMenuItem.Click += new System.EventHandler(this.tXTToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.eXITToolStripMenuItem.Text = "EXIT";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtmax
            // 
            this.txtmax.Location = new System.Drawing.Point(612, 414);
            this.txtmax.Name = "txtmax";
            this.txtmax.Size = new System.Drawing.Size(118, 22);
            this.txtmax.TabIndex = 4;
            // 
            // btndiemmax
            // 
            this.btndiemmax.Location = new System.Drawing.Point(476, 409);
            this.btndiemmax.Name = "btndiemmax";
            this.btndiemmax.Size = new System.Drawing.Size(130, 27);
            this.btndiemmax.TabIndex = 5;
            this.btndiemmax.Text = "Điểm cao nhất";
            this.btndiemmax.UseVisualStyleBackColor = true;
            this.btndiemmax.Click += new System.EventHandler(this.btndiemmax_Click);
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(612, 442);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(118, 22);
            this.txtmin.TabIndex = 4;
            // 
            // btndiemMIn
            // 
            this.btndiemMIn.Location = new System.Drawing.Point(476, 437);
            this.btndiemMIn.Name = "btndiemMIn";
            this.btndiemMIn.Size = new System.Drawing.Size(130, 27);
            this.btndiemMIn.TabIndex = 5;
            this.btndiemMIn.Text = "Điểm Thấp nhất";
            this.btndiemMIn.UseVisualStyleBackColor = true;
            this.btndiemMIn.Click += new System.EventHandler(this.btndiemmin_Click);
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(967, 427);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.Size = new System.Drawing.Size(118, 22);
            this.txtdtb.TabIndex = 4;
            // 
            // btndiemAvg
            // 
            this.btndiemAvg.Location = new System.Drawing.Point(831, 422);
            this.btndiemAvg.Name = "btndiemAvg";
            this.btndiemAvg.Size = new System.Drawing.Size(130, 37);
            this.btndiemAvg.TabIndex = 5;
            this.btndiemAvg.Text = "Điểm Trung Bình";
            this.btndiemAvg.UseVisualStyleBackColor = true;
            this.btndiemAvg.Click += new System.EventHandler(this.btndiemAvg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 572);
            this.Controls.Add(this.btndiemAvg);
            this.Controls.Add(this.btndiemMIn);
            this.Controls.Add(this.btndiemmax);
            this.Controls.Add(this.txtdtb);
            this.Controls.Add(this.txtmin);
            this.Controls.Add(this.txtmax);
            this.Controls.Add(this.dgvQL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQL)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvQL;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.TextBox txtDKT;
        private System.Windows.Forms.TextBox txtDQT;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.TextBox txtHT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm5;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm6;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oPENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAVEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXCELToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtmax;
        private System.Windows.Forms.Button btndiemmax;
        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.Button btndiemMIn;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.Button btndiemAvg;
    }
}

