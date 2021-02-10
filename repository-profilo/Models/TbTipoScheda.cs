using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbTipoScheda
    {
        public int CodTipoScheda { get; set; }
        public string CodServizio { get; set; }
        public string RetCode { get; set; }
        public string CodProdotto { get; set; }
        public string Descrizione { get; set; }
        public string TipoNdg { get; set; }
        public string Versione { get; set; }

        public virtual TbServizi CodServizioNavigation { get; set; }
    }
}
