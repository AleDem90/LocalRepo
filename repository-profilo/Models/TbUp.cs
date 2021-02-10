﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbUp
    {
        public string Up { get; set; }
        public string Descrizione { get; set; }
        public string Provincia { get; set; }
        public string Country { get; set; }
    }
}
