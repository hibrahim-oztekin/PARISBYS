using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class CrcmUyelikFormDurums : IEntity
    {
        public CrcmUyelikFormDurums()
        {
            this.Derneks = new List<Derneks>();
        }

        public byte Id { get; set; }
        public string Durum { get; set; }

        public List<Derneks> Derneks { get; set; }
    }


}
