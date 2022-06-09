using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class TrGorev : IEntity
    {
        public TrGorev()
        {
            this.Gorevlis = new List<Gorevlis>();
        }

        public int Id { get; set; }
        public int IlId { get; set; }
        public int IlceId { get; set; }
        public int UnvanId { get; set; }

        public List<Gorevlis> Gorevlis { get; set; }
    }


}
