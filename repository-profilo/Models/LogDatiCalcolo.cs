using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class LogDatiCalcolo
    {
        public int CodScheda { get; set; }
        public string Esperienza { get; set; }
        public string Conoscenza { get; set; }
        public string Investimenti { get; set; }
        public decimal? Puntidominv { get; set; }
        public decimal? Puntidomimp { get; set; }
        public decimal? PunteggioTotale { get; set; }
        public string CampoProfiloRischio { get; set; }
        public string Perc12m { get; set; }
        public string Perc36m { get; set; }
        public string Perc60m { get; set; }
        public string Perc84m { get; set; }
        public string Percmax { get; set; }
        public string CoefficienteHp1 { get; set; }
        public string CoefficienteHp2 { get; set; }
        public string CoefficienteHp3 { get; set; }
        public string CoefficienteHp4 { get; set; }
        public string CoefficienteHp5 { get; set; }
        public string Holding { get; set; }
        public string CampoHolding { get; set; }
        public string RisultatoFinalita { get; set; }
        public string Finalita { get; set; }
        public string CampiFonti { get; set; }
        public string CampoRisparmio { get; set; }
        public decimal? Punti8 { get; set; }
        public string CampoPatrimonio { get; set; }
        public decimal? Punti9 { get; set; }
        public decimal? PatrimonioBp { get; set; }
        public int? AddendoB { get; set; }
        public int? AddendoBRivalutato { get; set; }
        public decimal? SommaAddendi { get; set; }
        public decimal? PunteggioInv { get; set; }
        public string CampoPerdite { get; set; }
        public string CampoImpegni { get; set; }
        public decimal? Punti11 { get; set; }
        public string CampoImpegniPosidonia { get; set; }
        public decimal? Punti11Posidonia { get; set; }
        public string CampoImmobili { get; set; }
        public string ArPuntiBassa { get; set; }
        public string ArPuntiAlta { get; set; }
        public decimal? ImportoOperazioni { get; set; }
        public decimal? TotaleOperazioni { get; set; }
        public string Listanumopz { get; set; }
        public string Listanumopzmin { get; set; }
        public decimal? ImportoOperazioniMedio { get; set; }
        public string PreProfilo { get; set; }
        public string ClasseR { get; set; }
        public string ClasseReddito { get; set; }
        public string ClasseAttInv { get; set; }
        public string ClasseRedPatr { get; set; }
        public string ClasseImpFin { get; set; }
        public string ProfiloFin { get; set; }
        public string ProfiloTolRischio { get; set; }
        public string SituazioneFinanziaria { get; set; }
        public decimal? SommaPunti8911 { get; set; }
        public string ElencoCodiciFiscali { get; set; }
        public string DatiCalcolo { get; set; }
        public decimal? Ponderazione { get; set; }
        public decimal? PuntiNucleoFam { get; set; }
        public string Obiettivo { get; set; }
        public string CombinazRispObiettivo { get; set; }
        public string NumCqsBp { get; set; }
        public string NumPrestitiBp { get; set; }
        public string NumMutuiBp { get; set; }
        public string Appropriatezza { get; set; }
        public string ProfiloTolRischioOrig { get; set; }
        public string Ndg { get; set; }
        public string ProfiloEsg { get; set; }
        public string TotaleProfiloEsg { get; set; }
    }
}
