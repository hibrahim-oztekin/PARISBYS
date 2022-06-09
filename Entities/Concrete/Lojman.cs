using Core.Entities;

namespace Entities.Concrete
{
    public class Lojman : IEntity
    {
        public int Id { get; set; }
        public int CamiisId { get; set; }
        public int? MetreKare { get; set; }
        public int? OdaSayisi { get; set; }
        public int? Uzaklik { get; set; }

        public Camiis Camii { get; set; }
    }


}
