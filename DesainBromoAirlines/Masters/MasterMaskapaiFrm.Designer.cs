namespace DesainBromoAirlines.Masters
{
    partial class MasterMaskapaiFrm
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
            System.Windows.Forms.Label deskripsiLabel;
            System.Windows.Forms.Label jumlahKruLabel;
            System.Windows.Forms.Label perusahaanLabel;
            System.Windows.Forms.Label namaLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deskripsiTextBox = new System.Windows.Forms.TextBox();
            this.jumlahKruNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.perusahaanTextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UbahColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HapusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            deskripsiLabel = new System.Windows.Forms.Label();
            jumlahKruLabel = new System.Windows.Forms.Label();
            perusahaanLabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahKruNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(716, 576);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 35);
            this.button2.TabIndex = 25;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(847, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 35);
            this.button1.TabIndex = 24;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // deskripsiLabel
            // 
            deskripsiLabel.AutoSize = true;
            deskripsiLabel.Location = new System.Drawing.Point(619, 449);
            deskripsiLabel.Name = "deskripsiLabel";
            deskripsiLabel.Size = new System.Drawing.Size(67, 16);
            deskripsiLabel.TabIndex = 22;
            deskripsiLabel.Text = "Deskripsi:";
            // 
            // deskripsiTextBox
            // 
            this.deskripsiTextBox.Location = new System.Drawing.Point(716, 446);
            this.deskripsiTextBox.Multiline = true;
            this.deskripsiTextBox.Name = "deskripsiTextBox";
            this.deskripsiTextBox.Size = new System.Drawing.Size(235, 105);
            this.deskripsiTextBox.TabIndex = 23;
            // 
            // jumlahKruLabel
            // 
            jumlahKruLabel.AutoSize = true;
            jumlahKruLabel.Location = new System.Drawing.Point(34, 531);
            jumlahKruLabel.Name = "jumlahKruLabel";
            jumlahKruLabel.Size = new System.Drawing.Size(75, 16);
            jumlahKruLabel.TabIndex = 20;
            jumlahKruLabel.Text = "Jumlah Kru:";
            // 
            // jumlahKruNumericUpDown
            // 
            this.jumlahKruNumericUpDown.Location = new System.Drawing.Point(135, 529);
            this.jumlahKruNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumlahKruNumericUpDown.Name = "jumlahKruNumericUpDown";
            this.jumlahKruNumericUpDown.Size = new System.Drawing.Size(228, 22);
            this.jumlahKruNumericUpDown.TabIndex = 21;
            this.jumlahKruNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // perusahaanLabel
            // 
            perusahaanLabel.AutoSize = true;
            perusahaanLabel.Location = new System.Drawing.Point(33, 488);
            perusahaanLabel.Name = "perusahaanLabel";
            perusahaanLabel.Size = new System.Drawing.Size(83, 16);
            perusahaanLabel.TabIndex = 18;
            perusahaanLabel.Text = "Perusahaan:";
            // 
            // perusahaanTextBox
            // 
            this.perusahaanTextBox.Location = new System.Drawing.Point(136, 485);
            this.perusahaanTextBox.Name = "perusahaanTextBox";
            this.perusahaanTextBox.Size = new System.Drawing.Size(227, 22);
            this.perusahaanTextBox.TabIndex = 19;
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(30, 449);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 16;
            namaLabel.Text = "Nama:";
            // 
            // namaTextBox
            // 
            this.namaTextBox.Location = new System.Drawing.Point(135, 446);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(228, 22);
            this.namaTextBox.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UbahColumn,
            this.HapusColumn});
            this.dataGridView1.Location = new System.Drawing.Point(33, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(974, 316);
            this.dataGridView1.TabIndex = 15;
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
            // HapusColumn
            // 
            this.HapusColumn.HeaderText = "";
            this.HapusColumn.MinimumWidth = 6;
            this.HapusColumn.Name = "HapusColumn";
            this.HapusColumn.ReadOnly = true;
            this.HapusColumn.Text = "Hapus";
            this.HapusColumn.UseColumnTextForButtonValue = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Semua maskapai yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Master Maskapai";
            // 
            // MasterMaskapaiFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(deskripsiLabel);
            this.Controls.Add(this.deskripsiTextBox);
            this.Controls.Add(jumlahKruLabel);
            this.Controls.Add(this.jumlahKruNumericUpDown);
            this.Controls.Add(perusahaanLabel);
            this.Controls.Add(this.perusahaanTextBox);
            this.Controls.Add(namaLabel);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterMaskapaiFrm";
            this.Text = "MasterMaskapaiFrm";
            ((System.ComponentModel.ISupportInitialize)(this.jumlahKruNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox deskripsiTextBox;
        private System.Windows.Forms.NumericUpDown jumlahKruNumericUpDown;
        private System.Windows.Forms.TextBox perusahaanTextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn UbahColumn;
        private System.Windows.Forms.DataGridViewButtonColumn HapusColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}