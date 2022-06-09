using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Baskans : IEntity
    {
        public int Id { get; set; }
        public int DerneksId { get; set; }
        public string Ad { get; set; }
        public string SoyAd { get; set; }
        public string EPosta { get; set; }
        public string CepTel { get; set; }
        public DateTime BaslamaTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
        public bool Silindi { get; set; }

        public Derneks Dernek { get; set; }
    }


}
