using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbProfiliScheda
    {
        public string SCodProfilo { get; set; }
        public string SDescrizione { get; set; }
        public byte? NRangeDa { get; set; }
        public byte? NRangeA { get; set; }
    }
}
