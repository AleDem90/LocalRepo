using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class ValoriRisposte
    {
        public byte CodRisposta { get; set; }
        public byte CodDomanda { get; set; }
        public int CodTipoScheda { get; set; }
        public int? Valore { get; set; }
    }
}
