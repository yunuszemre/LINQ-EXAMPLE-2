using System;
using System.Collections.Generic;

namespace LINQ_EXAMPLE_2.Models
{
    public partial class VwSalesReport
    {
        public DateTime? SiparişTarihi { get; set; }
        public string? MüşteriFirmaAdı { get; set; }
        public string SatışPersoneliAdı { get; set; } = null!;
        public string? KargoFirması { get; set; }
        public DateTime? KargolanmaTarihi { get; set; }
        public string? TeslimAlacakKişi { get; set; }
    }
}
