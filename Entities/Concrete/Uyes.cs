using Core.Entities;

namespace Entities.Concrete
{
    public class Uyes : IEntity
    {
        public int Id { get; set; }
        public int DerneksId { get; set; }
        public int? KisiDernekUye { get; set; }
        public int? AileDernekUye { get; set; }
        public int Yil { get; set; }

        public Derneks Dernek { get; set; }
    }


}
