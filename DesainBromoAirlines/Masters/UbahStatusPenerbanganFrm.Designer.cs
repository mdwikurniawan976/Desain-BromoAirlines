namespace DesainBromoAirlines.Masters
{
    partial class UbahStatusPenerbanganFrm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.namaComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TerakhirDiubah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UbahColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(543, 453);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Perkiraan Durasi Delay";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(706, 453);
            this.maskedTextBox1.Mask = "00j\\am 00menit";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(269, 22);
            this.maskedTextBox1.TabIndex = 34;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(724, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 33;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(859, 504);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(116, 37);
            this.btnSimpan.TabIndex = 32;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            // 
            // namaComboBox
            // 
            this.namaComboBox.DisplayMember = "Nama";
            this.namaComboBox.FormattingEnabled = true;
            this.namaComboBox.Location = new System.Drawing.Point(74, 459);
            this.namaComboBox.Name = "namaComboBox";
            this.namaComboBox.Size = new System.Drawing.Size(204, 24);
            this.namaComboBox.TabIndex = 31;
            this.namaComboBox.ValueMember = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuan,
            this.WaktuKeberangkatan,
            this.StatusTerakhir,
            this.TerakhirDiubah,
            this.UbahColumn});
            this.dataGridView1.Location = new System.Drawing.Point(17, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(980, 336);
            this.dataGridView1.TabIndex = 30;
            // 
            // Maskapai
            // 
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 6;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.ReadOnly = true;
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.HeaderText = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 6;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.ReadOnly = true;
            // 
            // BandaraTujuan
            // 
            this.BandaraTujuan.HeaderText = "BandaraTujuan";
            this.BandaraTujuan.MinimumWidth = 6;
            this.BandaraTujuan.Name = "BandaraTujuan";
            this.BandaraTujuan.ReadOnly = true;
            // 
            // WaktuKeberangkatan
            // 
            this.WaktuKeberangkatan.HeaderText = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.MinimumWidth = 6;
            this.WaktuKeberangkatan.Name = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.ReadOnly = true;
            // 
            // StatusTerakhir
            // 
            this.StatusTerakhir.HeaderText = "StatusTerakhir";
            this.StatusTerakhir.MinimumWidth = 6;
            this.StatusTerakhir.Name = "StatusTerakhir";
            this.StatusTerakhir.ReadOnly = true;
            // 
            // TerakhirDiubah
            // 
            this.TerakhirDiubah.HeaderText = "TerakhirDiubah";
            this.TerakhirDiubah.MinimumWidth = 6;
            this.TerakhirDiubah.Name = "TerakhirDiubah";
            this.TerakhirDiubah.ReadOnly = true;
            // 
            // UbahColumn
            // 
            this.UbahColumn.HeaderText = "";
            this.UbahColumn.MinimumWidth = 6;
            this.UbahColumn.Name = "UbahColumn";
            this.UbahColumn.ReadOnly = true;
            this.UbahColumn.Text = "Ubah";
            this.UbahColumn.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Anda bisa mengubah status jadwal penerbangan disini\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ubah Status Penerbangan";
            // 
            // UbahStatusPenerbanganFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.namaComboBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UbahStatusPenerbanganFrm";
            this.Text = "UbahStatusPenerbanganFrm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox namaComboBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusTerakhir;
        private System.Windows.Forms.DataGridViewTextBoxColumn TerakhirDiubah;
        private System.Windows.Forms.DataGridViewButtonColumn UbahColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}