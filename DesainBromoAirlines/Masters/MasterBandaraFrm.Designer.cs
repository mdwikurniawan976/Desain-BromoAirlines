namespace DesainBromoAirlines.Masters
{
    partial class MasterBandaraFrm
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
            System.Windows.Forms.Label alamatLabel;
            System.Windows.Forms.Label jumlahTerminalLabel;
            System.Windows.Forms.Label kotaLabel;
            System.Windows.Forms.Label kodeIATALabel;
            System.Windows.Forms.Label namaLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.alamatTextBox = new System.Windows.Forms.TextBox();
            this.jumlahTerminalNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.kotaTextBox = new System.Windows.Forms.TextBox();
            this.kodeIATATextBox = new System.Windows.Forms.TextBox();
            this.namaTextBox = new System.Windows.Forms.TextBox();
            this.HapusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UbahColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            alamatLabel = new System.Windows.Forms.Label();
            jumlahTerminalLabel = new System.Windows.Forms.Label();
            kotaLabel = new System.Windows.Forms.Label();
            kodeIATALabel = new System.Windows.Forms.Label();
            namaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jumlahTerminalNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // alamatLabel
            // 
            alamatLabel.AutoSize = true;
            alamatLabel.Location = new System.Drawing.Point(560, 451);
            alamatLabel.Name = "alamatLabel";
            alamatLabel.Size = new System.Drawing.Size(52, 16);
            alamatLabel.TabIndex = 30;
            alamatLabel.Text = "Alamat:";
            // 
            // jumlahTerminalLabel
            // 
            jumlahTerminalLabel.AutoSize = true;
            jumlahTerminalLabel.Location = new System.Drawing.Point(556, 410);
            jumlahTerminalLabel.Name = "jumlahTerminalLabel";
            jumlahTerminalLabel.Size = new System.Drawing.Size(109, 16);
            jumlahTerminalLabel.TabIndex = 28;
            jumlahTerminalLabel.Text = "Jumlah Terminal:";
            // 
            // kotaLabel
            // 
            kotaLabel.AutoSize = true;
            kotaLabel.Location = new System.Drawing.Point(28, 485);
            kotaLabel.Name = "kotaLabel";
            kotaLabel.Size = new System.Drawing.Size(37, 16);
            kotaLabel.TabIndex = 24;
            kotaLabel.Text = "Kota:";
            // 
            // kodeIATALabel
            // 
            kodeIATALabel.AutoSize = true;
            kodeIATALabel.Location = new System.Drawing.Point(28, 448);
            kodeIATALabel.Name = "kodeIATALabel";
            kodeIATALabel.Size = new System.Drawing.Size(75, 16);
            kodeIATALabel.TabIndex = 22;
            kodeIATALabel.Text = "Kode IATA:";
            // 
            // namaLabel
            // 
            namaLabel.AutoSize = true;
            namaLabel.Location = new System.Drawing.Point(32, 410);
            namaLabel.Name = "namaLabel";
            namaLabel.Size = new System.Drawing.Size(47, 16);
            namaLabel.TabIndex = 20;
            namaLabel.Text = "Nama:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(650, 580);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 39);
            this.button2.TabIndex = 33;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // alamatTextBox
            // 
            this.alamatTextBox.Location = new System.Drawing.Point(671, 448);
            this.alamatTextBox.Multiline = true;
            this.alamatTextBox.Name = "alamatTextBox";
            this.alamatTextBox.Size = new System.Drawing.Size(248, 97);
            this.alamatTextBox.TabIndex = 31;
            // 
            // jumlahTerminalNumericUpDown
            // 
            this.jumlahTerminalNumericUpDown.Location = new System.Drawing.Point(671, 410);
            this.jumlahTerminalNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.jumlahTerminalNumericUpDown.Name = "jumlahTerminalNumericUpDown";
            this.jumlahTerminalNumericUpDown.Size = new System.Drawing.Size(248, 22);
            this.jumlahTerminalNumericUpDown.TabIndex = 29;
            this.jumlahTerminalNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 521);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 24);
            this.comboBox1.TabIndex = 27;
            this.comboBox1.ValueMember = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 522);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Negara";
            // 
            // kotaTextBox
            // 
            this.kotaTextBox.Location = new System.Drawing.Point(112, 483);
            this.kotaTextBox.Name = "kotaTextBox";
            this.kotaTextBox.Size = new System.Drawing.Size(235, 22);
            this.kotaTextBox.TabIndex = 25;
            // 
            // kodeIATATextBox
            // 
            this.kodeIATATextBox.Location = new System.Drawing.Point(112, 445);
            this.kodeIATATextBox.Name = "kodeIATATextBox";
            this.kodeIATATextBox.Size = new System.Drawing.Size(235, 22);
            this.kodeIATATextBox.TabIndex = 23;
            // 
            // namaTextBox
            // 
            this.namaTextBox.Location = new System.Drawing.Point(113, 407);
            this.namaTextBox.Name = "namaTextBox";
            this.namaTextBox.Size = new System.Drawing.Size(234, 22);
            this.namaTextBox.TabIndex = 21;
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
            // UbahColumn
            // 
            this.UbahColumn.HeaderText = "";
            this.UbahColumn.MinimumWidth = 6;
            this.UbahColumn.Name = "UbahColumn";
            this.UbahColumn.ReadOnly = true;
            this.UbahColumn.Text = "Ubah";
            this.UbahColumn.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(791, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 39);
            this.button1.TabIndex = 32;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
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
            this.dataGridView1.Location = new System.Drawing.Point(33, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 291);
            this.dataGridView1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Semua bandara yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Master Bandara";
            // 
            // MasterBandaraFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.alamatTextBox);
            this.Controls.Add(this.jumlahTerminalNumericUpDown);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kotaTextBox);
            this.Controls.Add(this.kodeIATATextBox);
            this.Controls.Add(this.namaTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(alamatLabel);
            this.Controls.Add(jumlahTerminalLabel);
            this.Controls.Add(kotaLabel);
            this.Controls.Add(kodeIATALabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(namaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterBandaraFrm";
            this.Text = "MasterBandaraFrm";
            ((System.ComponentModel.ISupportInitialize)(this.jumlahTerminalNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox alamatTextBox;
        private System.Windows.Forms.NumericUpDown jumlahTerminalNumericUpDown;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kotaTextBox;
        private System.Windows.Forms.TextBox kodeIATATextBox;
        private System.Windows.Forms.TextBox namaTextBox;
        private System.Windows.Forms.DataGridViewButtonColumn HapusColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UbahColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}