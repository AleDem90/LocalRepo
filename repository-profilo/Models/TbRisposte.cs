using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbRisposte
    {
        public byte CodRisposta { get; set; }
        public byte CodDomanda { get; set; }
        public int CodTipoScheda { get; set; }
        public string Descrizione { get; set; }
        public byte? Ordine { get; set; }
        public string DescPosizione { get; set; }
        public string Titolo { get; set; }
        public decimal? Punteggio { get; set; }
        public string DataScadenza { get; set; }
        public string Bloccante { get; set; }
        public string DescPosizioneFe { get; set; }
    }
}
