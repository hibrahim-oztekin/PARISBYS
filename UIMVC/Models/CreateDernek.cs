using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIMVC.Models
{
    public class CreateDernek : IEntity
    {
        public string Ad { get; set; }
        public int SehirId { get; set; }
        public byte KurulusKanunId { get; set; }
        public byte CrcmUyelikFormDurumId { get; set; }
        public byte BkBolgesId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime BaslangicTarih { get; set; }

    }
}
