using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class PreProfPg
    {
        public string Rischio { get; set; }
        public string Holding { get; set; }
        public string Punteggio { get; set; }
    }
}
