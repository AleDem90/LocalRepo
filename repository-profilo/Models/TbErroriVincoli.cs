using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbErroriVincoli
    {
        public int CodScheda { get; set; }
        public string Ndg { get; set; }
        public string Frazionario { get; set; }
        public string Operatore { get; set; }
        public string Terminale { get; set; }
        public string Data { get; set; }
        public string Ora { get; set; }
        public int? CodTipoScheda { get; set; }
        public string RispDomA { get; set; }
        public string RispDomB { get; set; }
        public string MsgErrore { get; set; }
    }
}
