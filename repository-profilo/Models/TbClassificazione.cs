using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbClassificazione
    {
        public string Ndg { get; set; }
        public string TipoClassificazione { get; set; }
        public string DescrClassificazione { get; set; }
        public string Data { get; set; }
        public string Operatore { get; set; }
        public string Terminale { get; set; }
        public string Frazionario { get; set; }
        public string IndicatoreFuoriSede { get; set; }
    }
}
