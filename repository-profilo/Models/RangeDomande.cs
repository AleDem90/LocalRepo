using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class RangeDomande
    {
        public byte CodDomanda { get; set; }
        public int CodTipoScheda { get; set; }
        public int? ValoreDa { get; set; }
        public long? ValoreA { get; set; }
        public string Punteggio { get; set; }
    }
}
