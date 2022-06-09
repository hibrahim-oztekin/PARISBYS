using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class Sehirs : IEntity
    {
        public Sehirs()
        {
            this.Adres = new List<DernekAdres>();
        }

        public int Id { get; set; }
        public string Ad { get; set; }

        public List<DernekAdres> Adres { get; set; }
    }


}
