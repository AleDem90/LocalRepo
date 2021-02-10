using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class CheckApproLog
    {
        public string DataInserimento { get; set; }
        public string Ndg { get; set; }
        public string RisVecchio { get; set; }
        public string RisNuovo { get; set; }
    }
}
