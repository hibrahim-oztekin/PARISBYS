using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{

    public class Yayins : IEntity
    {
        public Yayins()
        {
            this.Yayinlars = new List<Yayinlar>();
        }

        public byte Id { get; set; }
        public string Ad { get; set; }

        public List<Yayinlar> Yayinlars { get; set; }
    }


}
