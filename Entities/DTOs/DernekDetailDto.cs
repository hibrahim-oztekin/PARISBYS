using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class DernekDetailDto : IDto
    {
        public string Ad { get; set; }
        public int SehirId { get; set; }
        public byte KurulusKanunId { get; set; }
        public byte CrcmUyelikFormDurumId { get; set; }
        public byte BkBolgesId { get; set; }
        public DateTime KayitTarihi { get; set; }
        public DateTime BaslangicTarih { get; set; }
        public DateTime? BitisTarih { get; set; }
    }
}
