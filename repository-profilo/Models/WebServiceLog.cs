using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class WebServiceLog
    {
        public decimal Id { get; set; }
        public string Data { get; set; }
        public string Ora { get; set; }
        public string Metodo { get; set; }
        public string Xml { get; set; }
        public string Tipo { get; set; }
        public DateTime? Timestamp { get; set; }
        public string TempoEsecuzione { get; set; }
    }
}
