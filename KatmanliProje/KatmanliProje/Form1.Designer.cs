namespace KatmanliProje
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPage2 = new TabPage();
            bilgi = new Label();
            btnYeni_Parca = new Button();
            dataGridView2 = new DataGridView();
            comboBoxParca_Tur = new ComboBox();
            btnEkle_Parca = new Button();
            label4 = new Label();
            label3 = new Label();
            txtSahibi = new TextBox();
            txtFiyat = new TextBox();
            txtAd = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage1 = new TabPage();
            FiltreLabel = new Label();
            dataGridView_Parcalar = new DataGridView();
            comboBoxFiltre = new ComboBox();
            tabControl1 = new TabControl();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Parcalar).BeginInit();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(bilgi);
            tabPage2.Controls.Add(btnYeni_Parca);
            tabPage2.Controls.Add(dataGridView2);
            tabPage2.Controls.Add(comboBoxParca_Tur);
            tabPage2.Controls.Add(btnEkle_Parca);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(txtSahibi);
            tabPage2.Controls.Add(txtFiyat);
            tabPage2.Controls.Add(txtAd);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(718, 243);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Parça Düzenleme";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // bilgi
            // 
            bilgi.AutoSize = true;
            bilgi.Font = new Font("Segoe Print", 10F, FontStyle.Bold);
            bilgi.ForeColor = Color.Green;
            bilgi.Location = new Point(6, 162);
            bilgi.Name = "bilgi";
            bilgi.Size = new Size(147, 24);
            bilgi.TabIndex = 17;
            bilgi.Text = "Yeni Parça Eklendi!";
            // 
            // btnYeni_Parca
            // 
            btnYeni_Parca.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnYeni_Parca.Location = new Point(7, 128);
            btnYeni_Parca.Name = "btnYeni_Parca";
            btnYeni_Parca.Size = new Size(116, 31);
            btnYeni_Parca.TabIndex = 16;
            btnYeni_Parca.Text = "Yeni Parça";
            btnYeni_Parca.UseVisualStyleBackColor = true;
            btnYeni_Parca.Click += btnYeni_Parca_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToOrderColumns = true;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(251, 9);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(460, 223);
            dataGridView2.TabIndex = 14;
            // 
            // comboBoxParca_Tur
            // 
            comboBoxParca_Tur.FormattingEnabled = true;
            comboBoxParca_Tur.Items.AddRange(new object[] { "Islemci", "Anakart", "Ekran Karti", "Ram", "SSD", "Harddisk", "Güc Kaynaği" });
            comboBoxParca_Tur.Location = new Point(109, 99);
            comboBoxParca_Tur.Name = "comboBoxParca_Tur";
            comboBoxParca_Tur.Size = new Size(136, 23);
            comboBoxParca_Tur.TabIndex = 11;
            // 
            // btnEkle_Parca
            // 
            btnEkle_Parca.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnEkle_Parca.Location = new Point(129, 128);
            btnEkle_Parca.Name = "btnEkle_Parca";
            btnEkle_Parca.Size = new Size(116, 31);
            btnEkle_Parca.TabIndex = 10;
            btnEkle_Parca.Text = "KAYDET";
            btnEkle_Parca.UseVisualStyleBackColor = true;
            btnEkle_Parca.Click += btnEkle_Parca_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold);
            label4.Location = new Point(9, 102);
            label4.Name = "label4";
            label4.Size = new Size(47, 23);
            label4.TabIndex = 7;
            label4.Text = "Tür -";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(9, 9);
            label3.Name = "label3";
            label3.Size = new Size(63, 23);
            label3.TabIndex = 5;
            label3.Text = "Sahibi -";
            // 
            // txtSahibi
            // 
            txtSahibi.Location = new Point(109, 9);
            txtSahibi.Name = "txtSahibi";
            txtSahibi.Size = new Size(136, 23);
            txtSahibi.TabIndex = 4;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(109, 67);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(136, 23);
            txtFiyat.TabIndex = 2;
            // 
            // txtAd
            // 
            txtAd.Location = new Point(109, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(136, 23);
            txtAd.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(9, 68);
            label2.Name = "label2";
            label2.Size = new Size(57, 23);
            label2.TabIndex = 3;
            label2.Text = "Fiyat -";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(9, 39);
            label1.Name = "label1";
            label1.Size = new Size(93, 23);
            label1.TabIndex = 1;
            label1.Text = "Parça İsmi -";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(FiltreLabel);
            tabPage1.Controls.Add(dataGridView_Parcalar);
            tabPage1.Controls.Add(comboBoxFiltre);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(718, 243);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Parça Listesi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // FiltreLabel
            // 
            FiltreLabel.AutoSize = true;
            FiltreLabel.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FiltreLabel.Location = new Point(9, 12);
            FiltreLabel.Name = "FiltreLabel";
            FiltreLabel.Size = new Size(57, 23);
            FiltreLabel.TabIndex = 3;
            FiltreLabel.Text = "Filtrele";
            // 
            // dataGridView_Parcalar
            // 
            dataGridView_Parcalar.AllowUserToAddRows = false;
            dataGridView_Parcalar.AllowUserToOrderColumns = true;
            dataGridView_Parcalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_Parcalar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView_Parcalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Parcalar.Location = new Point(6, 42);
            dataGridView_Parcalar.MultiSelect = false;
            dataGridView_Parcalar.Name = "dataGridView_Parcalar";
            dataGridView_Parcalar.ReadOnly = true;
            dataGridView_Parcalar.RowHeadersWidth = 62;
            dataGridView_Parcalar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Parcalar.Size = new Size(709, 193);
            dataGridView_Parcalar.TabIndex = 0;
            dataGridView_Parcalar.CellClick += dataGridView_Parcalar_CellClick;
            // 
            // comboBoxFiltre
            // 
            comboBoxFiltre.FormattingEnabled = true;
            comboBoxFiltre.Location = new Point(91, 11);
            comboBoxFiltre.Name = "comboBoxFiltre";
            comboBoxFiltre.Size = new Size(121, 23);
            comboBoxFiltre.TabIndex = 1;
            comboBoxFiltre.SelectedIndexChanged += comboBoxFiltre_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(4, 5);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(726, 271);
            tabControl1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 280);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Parcalar).EndInit();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private Button btnYeni_Parca;
        private DataGridView dataGridView2;
        private ComboBox comboBoxParca_Tur;
        private Button btnEkle_Parca;
        private Label label4;
        private Label label3;
        private TextBox txtSahibi;
        private TextBox txtFiyat;
        private TextBox txtAd;
        private Label label2;
        private Label label1;
        private TabPage tabPage1;
        private Label FiltreLabel;
        private DataGridView dataGridView_Parcalar;
        private ComboBox comboBoxFiltre;
        private TabControl tabControl1;
        private Label bilgi;
    }
}
