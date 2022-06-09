using Core.Entities;

namespace Entities.Concrete
{
    public class BolgeNufus : IEntity
    {
        public int Id { get; set; }
        public int DerneksId { get; set; }
        public int? NufusSayisi { get; set; }
        public int? AileSayisi { get; set; }

        public Derneks Dernek { get; set; }
    }



}
