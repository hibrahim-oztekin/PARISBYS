using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Camiis : IEntity
    {
        public Camiis()
        {
            this.Lojmen = new List<Lojman>();
        }

        public int Id { get; set; }
        public int DernekId { get; set; }
        public byte GrubId { get; set; }
        public bool? MukabeleDurum { get; set; }
        public int? CemaatKapatisiToplam { get; set; }
        public int? SabahNamazi { get; set; }
        public int? OgleNamazi { get; set; }
        public int? IkindiNamazi { get; set; }
        public int? AksamNamazi { get; set; }
        public int? YatsiNamazi { get; set; }
        public int? CumaNamazi { get; set; }
        public int? BayramNamazi { get; set; }
        public string Yil { get; set; }

        public Derneks Dernek { get; set; }
        public CamiiGrup CamiiGrup { get; set; }
        public List<Lojman> Lojmen { get; set; }
    }




}
