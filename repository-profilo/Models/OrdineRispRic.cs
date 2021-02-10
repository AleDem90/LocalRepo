using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class OrdineRispRic
    {
        public int CodTipoSchedaA { get; set; }
        public int CodTipoSchedaB { get; set; }
        public byte CodRispostaA { get; set; }
        public byte CodRispostaB { get; set; }
    }
}
