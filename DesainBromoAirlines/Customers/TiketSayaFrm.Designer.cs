namespace DesainBromoAirlines.Customers
{
    partial class TiketSayaFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TiketSayaFrm));
            this.WaktuKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TanggalKeberangkatanC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraTujuanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandaraKeberangkatan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maskapai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KodePenerbangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StatusTerakhir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WaktuKeberangkatan
            // 
            this.WaktuKeberangkatan.HeaderText = "WaktuPenerbangan";
            this.WaktuKeberangkatan.MinimumWidth = 6;
            this.WaktuKeberangkatan.Name = "WaktuKeberangkatan";
            this.WaktuKeberangkatan.ReadOnly = true;
            // 
            // TanggalKeberangkatanC
            // 
            this.TanggalKeberangkatanC.HeaderText = "TanggalKeberangkatan";
            this.TanggalKeberangkatanC.MinimumWidth = 6;
            this.TanggalKeberangkatanC.Name = "TanggalKeberangkatanC";
            this.TanggalKeberangkatanC.ReadOnly = true;
            // 
            // BandaraTujuanColumn
            // 
            this.BandaraTujuanColumn.HeaderText = "BandaraTujuan";
            this.BandaraTujuanColumn.MinimumWidth = 6;
            this.BandaraTujuanColumn.Name = "BandaraTujuanColumn";
            this.BandaraTujuanColumn.ReadOnly = true;
            // 
            // BandaraKeberangkatan
            // 
            this.BandaraKeberangkatan.HeaderText = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.MinimumWidth = 6;
            this.BandaraKeberangkatan.Name = "BandaraKeberangkatan";
            this.BandaraKeberangkatan.ReadOnly = true;
            // 
            // Maskapai
            // 
            this.Maskapai.HeaderText = "Maskapai";
            this.Maskapai.MinimumWidth = 6;
            this.Maskapai.Name = "Maskapai";
            this.Maskapai.ReadOnly = true;
            // 
            // KodePenerbangan
            // 
            this.KodePenerbangan.HeaderText = "KodePenerbangan";
            this.KodePenerbangan.MinimumWidth = 6;
            this.KodePenerbangan.Name = "KodePenerbangan";
            this.KodePenerbangan.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KodePenerbangan,
            this.Maskapai,
            this.BandaraKeberangkatan,
            this.BandaraTujuanColumn,
            this.TanggalKeberangkatanC,
            this.WaktuKeberangkatan,
            this.StatusTerakhir});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(14, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(827, 321);
            this.dataGridView1.TabIndex = 9;
            // 
            // StatusTerakhir
            // 
            this.StatusTerakhir.HeaderText = "StatusTerakhir";
            this.StatusTerakhir.MinimumWidth = 6;
            this.StatusTerakhir.Name = "StatusTerakhir";
            this.StatusTerakhir.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Semua tiket anda yang aktif akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(71, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tiket Saya";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DesainBromoAirlines.Properties.Resources.chevron_left_solid_72;
            this.pictureBox1.Location = new System.Drawing.Point(14, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TiketSayaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(854, 432);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TiketSayaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Bromo Airlines - Tiket Saya";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn WaktuKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TanggalKeberangkatanC;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraTujuanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandaraKeberangkatan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maskapai;
        private System.Windows.Forms.DataGridViewTextBoxColumn KodePenerbangan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusTerakhir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}