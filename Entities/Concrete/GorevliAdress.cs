using Core.Entities;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public class GorevliAdress : IEntity
    {
        public GorevliAdress()
        {
            this.Gorevlis = new List<Gorevlis>();
        }

        public int Id { get; set; }
        public string Adres { get; set; }
        public int SehirsId { get; set; }
        public int PostaKod { get; set; }
        public bool Silindi { get; set; }

        public List<Gorevlis> Gorevlis { get; set; }
    }


}
