using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Gorevlis : IEntity
    {
        public int Id { get; set; }
        public int DerneksId { get; set; }
        public int? GorevliAdressId { get; set; }
        public int? TrGorevId { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string TCKimlik { get; set; }
        public byte? IzinGunId { get; set; }
        public bool VatanDaslikDurum { get; set; }
        public byte GorevStatusId { get; set; }
        public bool HafizlikDurum { get; set; }
        public int SicilNo { get; set; }
        public DateTime BaslamaTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
        public DateTime? UzatmaSonu { get; set; }
        public byte BolgeId { get; set; }
        public byte? MaasOdemeYerId { get; set; }
        public bool? Cinsiyet { get; set; }
        public string EPosta { get; set; }
        public string CepTel { get; set; }
        public string DogumYer { get; set; }
        public DateTime? DogumTarih { get; set; }
        public byte? OgrenimDurumId { get; set; }
        public bool Silindi { get; set; }

        public Derneks Dernek { get; set; }
        public GorevliAdress GorevliAdress { get; set; }
        public TrGorev TrGorev { get; set; }
        public IzinGun IzinGun { get; set; }
        public GorevStatus GorevStatus { get; set; }
        public Bolges Bolge { get; set; }
        public MaasOdemeYers MaasOdemeYer { get; set; }
        public OgrenimDurums OgrenimDurum { get; set; }
    }


}
