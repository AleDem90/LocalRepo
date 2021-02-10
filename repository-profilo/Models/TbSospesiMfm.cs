using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class TbSospesiMfm
    {
        public int CodSchedaU { get; set; }
        public int CodSchedaR { get; set; }
        public int CodTipoScheda { get; set; }
        public string Ndg { get; set; }
        public string Rapporto { get; set; }
        public string DataInserimento { get; set; }
        public string OraInserimento { get; set; }
        public string Servizio { get; set; }
        public string Frazionario { get; set; }
        public string Terminale { get; set; }
        public string Operatore { get; set; }
        public string Adeguatezza { get; set; }
        public string Appropriatezza { get; set; }
        public string Obiettivo1 { get; set; }
        public string Obiettivo2 { get; set; }
        public decimal? OrizzonteTemp { get; set; }
        public string SituazFin { get; set; }
        public string NucleoFam { get; set; }
        public string Obiettivo { get; set; }
        public string Eta { get; set; }
        public string ProgressivoU { get; set; }
        public string ProgressivoR { get; set; }
        public string Dichiarazione { get; set; }
        public string TipoColl { get; set; }
        public string NumRelazione { get; set; }
        public string CodProdotto { get; set; }
        public string Perc12m { get; set; }
        public string Perc36m { get; set; }
        public string Perc60m { get; set; }
        public string Perc84m { get; set; }
        public string Percmax { get; set; }
        public string NdgOperante { get; set; }
        public string ProfiloFin { get; set; }
        public string TipoQuest { get; set; }
        public string DataScadenza { get; set; }
        public string Matricola { get; set; }
        public string DenominazioneUp { get; set; }
        public string DescrProdotto { get; set; }
        public string NumConsulenza { get; set; }
        public string DomandeAggiornate { get; set; }
        public string ObiettivoInvestimenti { get; set; }
        public string PreferenzeEsg { get; set; }
        public string ProfiloEsg { get; set; }
        public string DomandeScadute { get; set; }
        public string DataDomandeScadute { get; set; }
    }
}
