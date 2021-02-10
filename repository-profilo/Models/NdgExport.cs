using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class NdgExport
    {
        public string Progr { get; set; }
        public string Ndg { get; set; }
        public string DataIac { get; set; }
        public string OraIac { get; set; }
        public string NumRif { get; set; }
        public string DataScadenza { get; set; }
        public string CodScheda { get; set; }
        public string OraIns { get; set; }
        public string Stato { get; set; }
        public string Msg { get; set; }
    }
}
