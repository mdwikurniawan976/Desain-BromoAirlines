namespace DesainBromoAirlines.Masters
{
    partial class MasterKodePromoFrm
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
            System.Windows.Forms.Label persentaseDiskonLabel;
            System.Windows.Forms.Label maksimumDiskonLabel;
            System.Windows.Forms.Label berlakuSampaiLabel;
            System.Windows.Forms.Label kodeLabel;
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.deskripsiTextBox = new System.Windows.Forms.TextBox();
            this.persentaseDiskonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.maksimumDiskonNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.berlakuSampaiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.kodeTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UbahColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.HapusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            deskripsiLabel = new System.Windows.Forms.Label();
            persentaseDiskonLabel = new System.Windows.Forms.Label();
            maksimumDiskonLabel = new System.Windows.Forms.Label();
            berlakuSampaiLabel = new System.Windows.Forms.Label();
            kodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.persentaseDiskonNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maksimumDiskonNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 569);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 37;
            this.button2.Text = "Batal";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(761, 569);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 36;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // deskripsiLabel
            // 
            deskripsiLabel.AutoSize = true;
            deskripsiLabel.Location = new System.Drawing.Point(532, 437);
            deskripsiLabel.Name = "deskripsiLabel";
            deskripsiLabel.Size = new System.Drawing.Size(67, 16);
            deskripsiLabel.TabIndex = 34;
            deskripsiLabel.Text = "Deskripsi:";
            // 
            // deskripsiTextBox
            // 
            this.deskripsiTextBox.Location = new System.Drawing.Point(623, 437);
            this.deskripsiTextBox.Multiline = true;
            this.deskripsiTextBox.Name = "deskripsiTextBox";
            this.deskripsiTextBox.Size = new System.Drawing.Size(301, 110);
            this.deskripsiTextBox.TabIndex = 35;
            // 
            // persentaseDiskonLabel
            // 
            persentaseDiskonLabel.AutoSize = true;
            persentaseDiskonLabel.Location = new System.Drawing.Point(33, 506);
            persentaseDiskonLabel.Name = "persentaseDiskonLabel";
            persentaseDiskonLabel.Size = new System.Drawing.Size(124, 16);
            persentaseDiskonLabel.TabIndex = 32;
            persentaseDiskonLabel.Text = "Persentase Diskon:";
            // 
            // persentaseDiskonNumericUpDown
            // 
            this.persentaseDiskonNumericUpDown.Location = new System.Drawing.Point(179, 506);
            this.persentaseDiskonNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.persentaseDiskonNumericUpDown.Name = "persentaseDiskonNumericUpDown";
            this.persentaseDiskonNumericUpDown.Size = new System.Drawing.Size(253, 22);
            this.persentaseDiskonNumericUpDown.TabIndex = 33;
            this.persentaseDiskonNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maksimumDiskonLabel
            // 
            maksimumDiskonLabel.AutoSize = true;
            maksimumDiskonLabel.Location = new System.Drawing.Point(33, 544);
            maksimumDiskonLabel.Name = "maksimumDiskonLabel";
            maksimumDiskonLabel.Size = new System.Drawing.Size(120, 16);
            maksimumDiskonLabel.TabIndex = 30;
            maksimumDiskonLabel.Text = "Maksimum Diskon:";
            // 
            // maksimumDiskonNumericUpDown
            // 
            this.maksimumDiskonNumericUpDown.Location = new System.Drawing.Point(179, 542);
            this.maksimumDiskonNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maksimumDiskonNumericUpDown.Name = "maksimumDiskonNumericUpDown";
            this.maksimumDiskonNumericUpDown.Size = new System.Drawing.Size(253, 22);
            this.maksimumDiskonNumericUpDown.TabIndex = 31;
            this.maksimumDiskonNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // berlakuSampaiLabel
            // 
            berlakuSampaiLabel.AutoSize = true;
            berlakuSampaiLabel.Location = new System.Drawing.Point(33, 467);
            berlakuSampaiLabel.Name = "berlakuSampaiLabel";
            berlakuSampaiLabel.Size = new System.Drawing.Size(106, 16);
            berlakuSampaiLabel.TabIndex = 28;
            berlakuSampaiLabel.Text = "Berlaku Sampai:";
            // 
            // berlakuSampaiDateTimePicker
            // 
            this.berlakuSampaiDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.berlakuSampaiDateTimePicker.Location = new System.Drawing.Point(179, 467);
            this.berlakuSampaiDateTimePicker.Name = "berlakuSampaiDateTimePicker";
            this.berlakuSampaiDateTimePicker.Size = new System.Drawing.Size(253, 22);
            this.berlakuSampaiDateTimePicker.TabIndex = 29;
            this.berlakuSampaiDateTimePicker.Value = new System.DateTime(2024, 2, 8, 0, 0, 0, 0);
            // 
            // kodeLabel
            // 
            kodeLabel.AutoSize = true;
            kodeLabel.Location = new System.Drawing.Point(33, 428);
            kodeLabel.Name = "kodeLabel";
            kodeLabel.Size = new System.Drawing.Size(42, 16);
            kodeLabel.TabIndex = 26;
            kodeLabel.Text = "Kode:";
            // 
            // kodeTextBox
            // 
            this.kodeTextBox.Location = new System.Drawing.Point(179, 428);
            this.kodeTextBox.Name = "kodeTextBox";
            this.kodeTextBox.Size = new System.Drawing.Size(253, 22);
            this.kodeTextBox.TabIndex = 27;
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
            this.dataGridView1.Location = new System.Drawing.Point(36, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(968, 282);
            this.dataGridView1.TabIndex = 25;
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
            this.label2.Location = new System.Drawing.Point(33, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Semua kode promo yang terdaftar akan muncul disini";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Master Kode Promo";
            // 
            // MasterKodePromoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(deskripsiLabel);
            this.Controls.Add(this.deskripsiTextBox);
            this.Controls.Add(persentaseDiskonLabel);
            this.Controls.Add(this.persentaseDiskonNumericUpDown);
            this.Controls.Add(maksimumDiskonLabel);
            this.Controls.Add(this.maksimumDiskonNumericUpDown);
            this.Controls.Add(berlakuSampaiLabel);
            this.Controls.Add(this.berlakuSampaiDateTimePicker);
            this.Controls.Add(kodeLabel);
            this.Controls.Add(this.kodeTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MasterKodePromoFrm";
            this.Text = "MasterKodePromoFrm";
            ((System.ComponentModel.ISupportInitialize)(this.persentaseDiskonNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maksimumDiskonNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox deskripsiTextBox;
        private System.Windows.Forms.NumericUpDown persentaseDiskonNumericUpDown;
        private System.Windows.Forms.NumericUpDown maksimumDiskonNumericUpDown;
        private System.Windows.Forms.DateTimePicker berlakuSampaiDateTimePicker;
        private System.Windows.Forms.TextBox kodeTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn UbahColumn;
        private System.Windows.Forms.DataGridViewButtonColumn HapusColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}