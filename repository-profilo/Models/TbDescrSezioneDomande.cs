using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbDescrSezioneDomande
    {
        public string Sezione { get; set; }
        public string Descrizione { get; set; }
        public int CodTipoScheda { get; set; }
    }
}
