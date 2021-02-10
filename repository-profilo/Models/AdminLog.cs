using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class AdminLog
    {
        public string Funzione { get; set; }
        public string Log { get; set; }
        public string Operatore { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
