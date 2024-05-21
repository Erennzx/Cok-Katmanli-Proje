using KatmanliProje.ÝsKatmani;
using KatmanliProje.Modeller;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;

namespace KatmanliProje
{
    public partial class Form1 : Form
    {
        islemler _is = new islemler();

        public int degisken = 0;
        public Form1()
        {
            InitializeComponent();
        }

        public int secilen = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxFiltreAyar();
            parcaDuzenlemeDGridAyar();
        }

        public void parcaDuzenlemeDGridAyar()
        {
            dGridAyar(dataGridView2);
        }

        // comboBox Filtre
        public void cboxFiltreAyar()
        {
            Parca tumParca = new Parca();
            tumParca.Tur = "Tüm Parçalar";
            tumParca.Id = 0;
            comboBoxFiltre.Items.Add(tumParca);
            Parca parca1 = new Parca();
            parca1.Tur = "Ekran Karti";
            parca1.Id = 1;
            comboBoxFiltre.Items.Add(parca1);
            Parca parca2 = new Parca();
            parca2.Tur = "Islemci";
            parca2.Id = 2;
            comboBoxFiltre.Items.Add(parca2);
            Parca parca3 = new Parca();
            parca3.Tur = "Anakart";
            parca3.Id = 3;
            comboBoxFiltre.Items.Add(parca3);
            Parca parca4 = new Parca();
            parca4.Tur = "Ram";
            parca4.Id = 4;
            comboBoxFiltre.Items.Add(parca4);
            Parca parca5 = new Parca();
            parca5.Tur = "SSD";
            parca5.Id = 5;
            comboBoxFiltre.Items.Add(parca5);
            Parca parca6 = new Parca();
            parca6.Tur = "Harddisk";
            parca6.Id = 6;
            comboBoxFiltre.Items.Add(parca6);
            Parca parca7 = new Parca();
            parca7.Tur = "Guc Kaynaði";
            parca7.Id = 7;
            comboBoxFiltre.Items.Add(parca7);

            comboBoxFiltre.SelectedIndex = 0;
            comboBoxFiltre.DisplayMember = "Tur";
        }

        // comboBox Filtre

        private void dGridAyar(DataGridView d)
        {
            d.DataSource = _is.parcaListesi();
            d.Columns[0].Visible = false;
            d.ColumnHeadersVisible = true;
        }

        // DataGrid Ayar

        // Yeni Parça

        private void btnYeni_Parca_Click(object sender, EventArgs e)
        {
            secilen = 0;
            txtAd.Clear();
            txtFiyat.Clear();
            txtSahibi.Clear();
            comboBoxParca_Tur.SelectedIndex = -1;
        }

        private void btnEkle_Parca_Click(object sender, EventArgs e)
        {
            degisken = comboBoxFiltre.SelectedIndex;

            _is.parcaEkle(secilen, txtSahibi.Text, txtAd.Text, txtFiyat.Text, comboBoxParca_Tur.SelectedItem);
            dataGridView2.Refresh();

            if (comboBoxFiltre.SelectedIndex == 0)
            {
                comboBoxFiltre.SelectedIndex = 1;
                comboBoxFiltre.SelectedIndex = degisken;
            }
            else
            {
                comboBoxFiltre.SelectedIndex = 0;
                comboBoxFiltre.SelectedIndex = degisken;
            }

            dataGridView_Parcalar.Refresh();
        }

        // Yeni Parça

        private void dataGridView_Parcalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5)
            {
                var kayit = dataGridView_Parcalar.Rows[e.RowIndex];
                parcaKayitDuzenle(kayit);
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == 6)
            {
                var kayit = dataGridView_Parcalar.Rows[e.RowIndex].Cells[2].Value;
                _is.parcaSil(Int32.Parse(kayit.ToString()));

                if (comboBoxFiltre.SelectedIndex == 0)
                {
                    comboBoxFiltre.SelectedIndex = 1;
                    comboBoxFiltre.SelectedIndex = degisken;
                }
                else
                {
                    comboBoxFiltre.SelectedIndex = 0;
                    comboBoxFiltre.SelectedIndex = degisken;
                }
            }
        }

        public void parcaKayitDuzenle(DataGridViewRow kayit)
        {
            txtAd.Text = kayit.Cells[1].Value.ToString();
            txtFiyat.Text = kayit.Cells[2].Value.ToString();
            txtSahibi.Text = kayit.Cells[4].Value.ToString();
            comboBoxParca_Tur.SelectedItem = kayit.Cells[3].Value;
            secilen = Int32.Parse(txtFiyat.Text);
            tabControl1.SelectedIndex = 1;
        }

        private void comboBoxFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            dGridAyar(dataGridView_Parcalar);

            dataGridView_Parcalar.Columns.Clear();
            dataGridView_Parcalar.DataSource = null;

            dataGridView_Parcalar.DataSource = _is.parcaListesi((Parca)comboBoxFiltre.SelectedItem);

            dataGridView_Parcalar.Columns[0].Visible = false;
            dataGridView_Parcalar.ColumnHeadersVisible = true;

            // düzenleme btn
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.Text = "Düzenle";
            dataGridView_Parcalar.Columns.Add(btn);
            // silme btn
            btn = new DataGridViewButtonColumn();
            btn.UseColumnTextForButtonValue = true;
            btn.Text = "Sil";
            dataGridView_Parcalar.Columns.Add(btn);
        }
    }
}
