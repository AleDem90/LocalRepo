using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class LogSospesi
    {
        public decimal? Codice { get; set; }
        public string DataLog { get; set; }
        public int? CodSchedaU { get; set; }
        public int? CodSchedaR { get; set; }
        public string Ndg { get; set; }
        public string DataIns { get; set; }
        public string OraIns { get; set; }
        public string Tipo { get; set; }
        public string Metodo { get; set; }
        public string Testo { get; set; }
    }
}
