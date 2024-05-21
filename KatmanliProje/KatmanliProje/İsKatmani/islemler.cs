using KatmanliProje.Modeller;
using KatmanliProje.VeriKatmani;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KatmanliProje.İsKatmani
{
    internal class islemler
    {
        veritabani vt = new veritabani();

        public BindingList<Parca> parcaListesi() => vt.parcaVeriYukle();

        public List<Parca> parcaListesi(Parca filtre)
        {
            if (filtre.Id != 0)
                return vt.parcaVeriYukle(filtre.Tur.ToString());
            else
                return vt.parcaVeriYukle("");
        }

        public void parcaEkle(int secilen, object Sahibi, object Ad, object Fiyat, object Tur)
        {
            if (Sahibi != null & Ad != null & Fiyat != null & Tur != null)
            {
                Parca yeniParca = new Parca();
                yeniParca.Sahibi = Sahibi.ToString();
                yeniParca.Ad = Ad.ToString();
                yeniParca.Fiyat = Convert.ToInt32(Fiyat);
                yeniParca.Tur = Tur.ToString();

                if (secilen == 0)
                {
                    vt.yeniParcaEkle(yeniParca);
                    //MessageBox.Show("Yeni Parça Eklendi");
                }
                else
                {
                    vt.parcaGuncelle(secilen, yeniParca);
                    //MessageBox.Show("Seçilen Parça Bilgileri Güncellendi");
                }
            }
            else
            {
                //MessageBox.Show("Lütfen Bütün Alanları Doldurunuz");
            }
        }

        public void parcaSil(int id)
        {
            vt.parcaSil(id);
        }
    }
}
