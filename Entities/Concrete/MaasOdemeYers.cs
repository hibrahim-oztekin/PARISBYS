using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class MaasOdemeYers : IEntity
    {
        public MaasOdemeYers()
        {
            this.Gorevlis = new List<Gorevlis>();
        }

        public byte Id { get; set; }
        public string Ad { get; set; }

        public List<Gorevlis> Gorevlis { get; set; }
    }


}
