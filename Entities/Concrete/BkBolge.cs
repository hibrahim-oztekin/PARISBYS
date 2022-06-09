using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class BkBolges : IEntity
    {
        public BkBolges()
        {
            this.Derneks = new List<Derneks>();
        }

        public byte Id { get; set; }
        public string Ad { get; set; }

        public List<Derneks> Derneks { get; set; }
    }


}
