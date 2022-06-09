using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class CamiiGrup : IEntity
    {
        public CamiiGrup()
        {
            this.Camiis = new List<Camiis>();
        }

        public byte Id { get; set; }
        public string Ad { get; set; }

        public List<Camiis> Camiis { get; set; }
    }


}
