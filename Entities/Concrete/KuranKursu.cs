using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class KuranKursu : IEntity
    {
        public int Id { get; set; }
        public int DerneksId { get; set; }
        public bool? CocukYasSinifDurum { get; set; }
        public int? CocukOgrenci { get; set; }
        public int? ErkekOgrenci { get; set; }
        public int? KizOgrenci { get; set; }
        public int? YetiskinErkekOgrenci { get; set; }
        public int? YetiskinBayanOgrenci { get; set; }
        public int? GencErkekOgrenci { get; set; }
        public int? GencKizOgrenci { get; set; }
        public int? YabanciOgrenci { get; set; }
        public int? OgreticiSayisi { get; set; }
        public int? Yil { get; set; }
        public DateTime? KayitTarihi { get; set; }

        public Derneks Dernek { get; set; }
    }


}
