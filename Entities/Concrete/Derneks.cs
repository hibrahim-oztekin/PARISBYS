using Core.Entities;
using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Derneks : IEntity
    {
        public Derneks()
        {
            this.Adres = new List<DernekAdres>();
            this.Baskans = new List<Baskans>();
            this.BolgeNufus = new List<BolgeNufus>();
            this.Camiis = new List<Camiis>();
            this.Gorevlis = new List<Gorevlis>();
            this.KuranKursus = new List<KuranKursu>();
            this.Uyes = new List<Uyes>();
            this.Yayinlars = new List<Yayinlar>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }
        public int SehirId { get; set; }
        public byte KurulusKanunId { get; set; }
        public byte CrcmUyelikFormDurumId { get; set; }
        public byte BkBolgesId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }

        public KurulusKanuns KurulusKanun { get; set; }
        public CrcmUyelikFormDurums CrcmUyelikFormDurum { get; set; }
        public BkBolges BkBolge { get; set; }
        public List<DernekAdres> Adres { get; set; }
        public List<Baskans> Baskans { get; set; }
        public List<BolgeNufus> BolgeNufus { get; set; }
        public List<Camiis> Camiis { get; set; }
        public List<Gorevlis> Gorevlis { get; set; }
        public List<KuranKursu> KuranKursus { get; set; }
        public List<Uyes> Uyes { get; set; }
        public List<Yayinlar> Yayinlars { get; set; }
    }


}
