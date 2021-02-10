using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbSchedaCl
    {
        public TbSchedaCl()
        {
            TbRisposteSchedaCl = new HashSet<TbRisposteSchedaCl>();
        }

        public int CodSchedaCl { get; set; }
        public string Ndg { get; set; }
        public string Rapporto { get; set; }
        public string Servizio { get; set; }
        public string Frazionario { get; set; }
        public string Terminale { get; set; }
        public string DataInserimento { get; set; }
        public string OraInserimento { get; set; }
        public int CodTipoScheda { get; set; }
        public string Progressivo { get; set; }
        public string TipoColl { get; set; }

        public virtual ICollection<TbRisposteSchedaCl> TbRisposteSchedaCl { get; set; }
    }
}
