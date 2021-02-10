using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class VersioniQuestionario
    {
        public decimal Versione { get; set; }
        public decimal CodTipoScheda { get; set; }
        public string DataDecorrenza { get; set; }
        public string DataScadenza { get; set; }
        public string ScadenzaQuestionari { get; set; }
        public string TipoNdg { get; set; }
    }
}
