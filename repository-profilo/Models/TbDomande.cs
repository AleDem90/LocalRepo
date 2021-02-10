using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbDomande
    {
        public byte CodDomanda { get; set; }
        public int CodTipoScheda { get; set; }
        public byte? CodDomandaPadre { get; set; }
        public string Descrizione { get; set; }
        public string Titolo { get; set; }
        public byte? Ordine { get; set; }
        public string DescPosizione { get; set; }
        public byte? NumRisposte { get; set; }
        public string Obbligatoria { get; set; }
        public decimal? Peso { get; set; }
        public string DataScadenza { get; set; }
        public string Nota { get; set; }
        public string Multirisposta { get; set; }
        public string Sezione { get; set; }
        public string Adeguatezza { get; set; }
        public string Appropriatezza { get; set; }
        public string Layout { get; set; }
        public string Modulo { get; set; }
        public string Bloccante { get; set; }
        public string DescrAggiuntiva { get; set; }
        public string Info { get; set; }
        public string DescPosizioneFe { get; set; }
        public string DescrTooltip { get; set; }
        public string EspCon { get; set; }
    }
}
