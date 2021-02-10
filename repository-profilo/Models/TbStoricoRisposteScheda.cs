using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbStoricoRisposteScheda
    {
        public int CodScheda { get; set; }
        public byte CodDomanda { get; set; }
        public byte CodRisposta { get; set; }
        public string Scelta { get; set; }
        public byte? Temp { get; set; }
    }
}
