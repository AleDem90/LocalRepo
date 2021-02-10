using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbLog
    {
        public string SData { get; set; }
        public string SOra { get; set; }
        public string NCodNdg { get; set; }
        public string NCodRapporto { get; set; }
        public string SCatRapporto { get; set; }
        public string NCodServizio { get; set; }
        public string SFrazionario { get; set; }
        public string STerminale { get; set; }
        public string SOperazione { get; set; }
        public int? NCodQuestionario { get; set; }
        public int? NCodIntervista { get; set; }
    }
}
