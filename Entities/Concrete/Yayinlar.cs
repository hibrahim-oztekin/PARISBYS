using Core.Entities;

namespace Entities.Concrete
{
    public class Yayinlar : IEntity
    {
        public int Id { get; set; }
        public int DerneksId { get; set; }
        public byte YayinId { get; set; }
        public int Sayi { get; set; }
        public int Yil { get; set; }

        public Derneks Dernek { get; set; }
        public Yayins Yayin { get; set; }
    }


}
