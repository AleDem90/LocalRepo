﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbVincoliCoerenzaDomande
    {
        public byte CodDomanda { get; set; }
        public int CodTipoScheda { get; set; }
        public string CodRisposta { get; set; }
        public byte? EtaMax { get; set; }
        public string Messaggio { get; set; }
        public string MsgErrore { get; set; }
        public string VincoloBackend { get; set; }
    }
}
