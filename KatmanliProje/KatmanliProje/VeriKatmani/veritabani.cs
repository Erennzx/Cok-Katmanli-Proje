using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatmanliProje.Modeller;
using System.ComponentModel;
using System.Drawing;

namespace KatmanliProje.VeriKatmani
{
    internal class veritabani:DbContext
    {
        public DbSet<Parca> Parcalar {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=Proje;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public BindingList<Parca> parcaVeriYukle()
        {
            Parcalar.Load();
            return Parcalar.Local.ToBindingList();
        }
        public List<Parca> parcaVeriYukle(object filtre)
        {
            Parcalar.Load();
            if (filtre.ToString() != "")
                return Parcalar.Local.Where(x => x.Tur == filtre.ToString()).ToList();
            else
                return Parcalar.Local.ToList();
        }

        public void yeniParcaEkle(Parca yeniParca)
        {
            Parcalar.Add(yeniParca);
            SaveChanges();
        }

        public void parcaGuncelle(int secilen, Parca parca)
        {
            var _ogr = Parcalar.First(x => x.Fiyat == secilen);
            if (_ogr != null)
            {
                _ogr.Ad = parca.Ad;
                _ogr.Fiyat = parca.Fiyat;
                _ogr.Sahibi = parca.Sahibi;
                _ogr.Tur = parca.Tur;
            }
            SaveChanges();
        }

        public void parcaSil(int id)
        {
            var parca = Parcalar.First(x => x.Fiyat == id);
            Parcalar.Remove(parca);
            SaveChanges();
        }
    }
}
