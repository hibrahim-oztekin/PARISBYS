using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class KurulusKanuns : IEntity
    {
        public KurulusKanuns()
        {
            this.Derneks = new List<Derneks>();
        }

        public byte Id { get; set; }
        public string Kanun { get; set; }

        public List<Derneks> Derneks { get; set; }
    }


}
