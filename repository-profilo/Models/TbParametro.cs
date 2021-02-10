using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbParametro
    {
        public decimal NumGiorni { get; set; }
        public string Valore { get; set; }
        public string DataInizio { get; set; }
        public string DataFine { get; set; }
    }
}
