using Core.Entities;

namespace Entities.Concrete
{
    public class DernekAdres : IEntity
    {
        public int Id { get; set; }
        public int DerneksId { get; set; }
        public string Adres { get; set; }
        public int SehirId { get; set; }
        public int PostaKodu { get; set; }
        public bool Silindi { get; set; }

        public Derneks Dernek { get; set; }
        public Sehirs Sehir { get; set; }
    }



}
