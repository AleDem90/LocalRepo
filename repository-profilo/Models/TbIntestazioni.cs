using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbIntestazioni
    {
        public string TipoScheda { get; set; }
        public byte CodDomanda { get; set; }
        public byte CodRisposta { get; set; }
        public byte OrdineDomanda { get; set; }
        public byte OrdineRisposta { get; set; }
        public string Testo { get; set; }
        public byte? Progressivo { get; set; }
    }
}
