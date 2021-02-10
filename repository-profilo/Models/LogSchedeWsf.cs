using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class LogSchedeWsf
    {
        public decimal? Codice { get; set; }
        public string DataLog { get; set; }
        public string Tipo { get; set; }
        public string NumDomanda { get; set; }
        public string NomCliente { get; set; }
        public string Causale { get; set; }
        public string Regolamento { get; set; }
        public string NumCc { get; set; }
        public int? CodSchedaU { get; set; }
        public int? CodSchedaR { get; set; }
        public string Ndg { get; set; }
        public string Msg { get; set; }
        public string Crf { get; set; }
    }
}
