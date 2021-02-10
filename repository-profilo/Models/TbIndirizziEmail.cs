﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbIndirizziEmail
    {
        public int CodScheda { get; set; }
        public string TipoDoc { get; set; }
        public string NdgRapp { get; set; }
        public string Cf { get; set; }
        public string Email { get; set; }
    }
}