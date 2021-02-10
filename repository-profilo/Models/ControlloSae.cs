using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class ControlloSae
    {
        public string Ciae { get; set; }
        public string Sae { get; set; }
        public byte CodRisposta { get; set; }
        public string TipoClas { get; set; }
        public string Anagrafe { get; set; }
    }
}
