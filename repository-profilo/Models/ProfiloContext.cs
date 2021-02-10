using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace repository_profilo.Models
{
    public partial class ProfiloContext : DbContext
    {
        public ProfiloContext()
        {
        }

        public ProfiloContext(DbContextOptions<ProfiloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdminLog> AdminLog { get; set; }
        public virtual DbSet<CalcLog> CalcLog { get; set; }
        public virtual DbSet<CheckApproLog> CheckApproLog { get; set; }
        public virtual DbSet<ClasseAttInv> ClasseAttInv { get; set; }
        public virtual DbSet<ClasseImpFin> ClasseImpFin { get; set; }
        public virtual DbSet<ClasseImpFinPg> ClasseImpFinPg { get; set; }
        public virtual DbSet<ClasseRedPatr> ClasseRedPatr { get; set; }
        public virtual DbSet<ClasseRedPatrPg> ClasseRedPatrPg { get; set; }
        public virtual DbSet<ClasseReddito> ClasseReddito { get; set; }
        public virtual DbSet<ClasseRedditoPg> ClasseRedditoPg { get; set; }
        public virtual DbSet<ControlloSae> ControlloSae { get; set; }
        public virtual DbSet<DescProfTolRischio> DescProfTolRischio { get; set; }
        public virtual DbSet<DescProfTolRischioPg> DescProfTolRischioPg { get; set; }
        public virtual DbSet<DescProfiloEsg> DescProfiloEsg { get; set; }
        public virtual DbSet<DescSituazFin> DescSituazFin { get; set; }
        public virtual DbSet<EtaDurataInv> EtaDurataInv { get; set; }
        public virtual DbSet<ExpQuestConsob> ExpQuestConsob { get; set; }
        public virtual DbSet<Finalita> Finalita { get; set; }
        public virtual DbSet<FinalitaPg> FinalitaPg { get; set; }
        public virtual DbSet<LogDatiCalcolo> LogDatiCalcolo { get; set; }
        public virtual DbSet<LogDatiHost> LogDatiHost { get; set; }
        public virtual DbSet<LogSchedeWsf> LogSchedeWsf { get; set; }
        public virtual DbSet<LogSospesi> LogSospesi { get; set; }
        public virtual DbSet<NdgExport> NdgExport { get; set; }
        public virtual DbSet<ObiettivoInv> ObiettivoInv { get; set; }
        public virtual DbSet<OrdineDomUnico> OrdineDomUnico { get; set; }
        public virtual DbSet<OrdineRispRic> OrdineRispRic { get; set; }
        public virtual DbSet<OrdineRispUnico> OrdineRispUnico { get; set; }
        public virtual DbSet<PreProf> PreProf { get; set; }
        public virtual DbSet<PreProfPg> PreProfPg { get; set; }
        public virtual DbSet<ProfiloFinanziario> ProfiloFinanziario { get; set; }
        public virtual DbSet<ProfiloFinanziarioPg> ProfiloFinanziarioPg { get; set; }
        public virtual DbSet<ProfiloTolRischio> ProfiloTolRischio { get; set; }
        public virtual DbSet<ProfiloTolRischioPg> ProfiloTolRischioPg { get; set; }
        public virtual DbSet<RangeDomande> RangeDomande { get; set; }
        public virtual DbSet<TbClassificazione> TbClassificazione { get; set; }
        public virtual DbSet<TbDescrSezioneDomande> TbDescrSezioneDomande { get; set; }
        public virtual DbSet<TbDomande> TbDomande { get; set; }
        public virtual DbSet<TbErroriVincoli> TbErroriVincoli { get; set; }
        public virtual DbSet<TbIndirizziEmail> TbIndirizziEmail { get; set; }
        public virtual DbSet<TbIntestazioni> TbIntestazioni { get; set; }
        public virtual DbSet<TbLog> TbLog { get; set; }
        public virtual DbSet<TbObiettivi> TbObiettivi { get; set; }
        public virtual DbSet<TbObiettiviPg> TbObiettiviPg { get; set; }
        public virtual DbSet<TbParametro> TbParametro { get; set; }
        public virtual DbSet<TbProfiliScheda> TbProfiliScheda { get; set; }
        public virtual DbSet<TbProgressivi> TbProgressivi { get; set; }
        public virtual DbSet<TbRisposte> TbRisposte { get; set; }
        public virtual DbSet<TbRisposteSRic> TbRisposteSRic { get; set; }
        public virtual DbSet<TbRisposteScheda> TbRisposteScheda { get; set; }
        public virtual DbSet<TbRisposteSchedaCl> TbRisposteSchedaCl { get; set; }
        public virtual DbSet<TbSchedaCl> TbSchedaCl { get; set; }
        public virtual DbSet<TbSchedaRicorrente> TbSchedaRicorrente { get; set; }
        public virtual DbSet<TbSchedaUnico> TbSchedaUnico { get; set; }
        public virtual DbSet<TbSchedaUnicoNew> TbSchedaUnicoNew { get; set; }
        public virtual DbSet<TbServizi> TbServizi { get; set; }
        public virtual DbSet<TbSospesi> TbSospesi { get; set; }
        public virtual DbSet<TbSospesiMfm> TbSospesiMfm { get; set; }
        public virtual DbSet<TbStatoIntervista> TbStatoIntervista { get; set; }
        public virtual DbSet<TbStoricoClassificazione> TbStoricoClassificazione { get; set; }
        public virtual DbSet<TbStoricoRicorrente> TbStoricoRicorrente { get; set; }
        public virtual DbSet<TbStoricoRicorrenteBackup> TbStoricoRicorrenteBackup { get; set; }
        public virtual DbSet<TbStoricoRisRicBackup> TbStoricoRisRicBackup { get; set; }
        public virtual DbSet<TbStoricoRisUBackup> TbStoricoRisUBackup { get; set; }
        public virtual DbSet<TbStoricoRisposteSRic> TbStoricoRisposteSRic { get; set; }
        public virtual DbSet<TbStoricoRisposteScheda> TbStoricoRisposteScheda { get; set; }
        public virtual DbSet<TbStoricoUnico> TbStoricoUnico { get; set; }
        public virtual DbSet<TbStoricoUnicoBackup> TbStoricoUnicoBackup { get; set; }
        public virtual DbSet<TbTipoScheda> TbTipoScheda { get; set; }
        public virtual DbSet<TbUp> TbUp { get; set; }
        public virtual DbSet<TbUpFiltro> TbUpFiltro { get; set; }
        public virtual DbSet<TbVincoliCoerenzaDomande> TbVincoliCoerenzaDomande { get; set; }
        public virtual DbSet<TbVincoliCoerenzaRisposte> TbVincoliCoerenzaRisposte { get; set; }
        public virtual DbSet<UtenzeAdmin> UtenzeAdmin { get; set; }
        public virtual DbSet<ValoriRisposte> ValoriRisposte { get; set; }
        public virtual DbSet<VersioniQuestionario> VersioniQuestionario { get; set; }
        public virtual DbSet<WebServiceLog> WebServiceLog { get; set; }
        public virtual DbSet<WebStringhe> WebStringhe { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseOracle("Data Source=(DESCRIPTION=(ADDRESS = (PROTOCOL = TCP)(HOST = 10.177.69.92)(PORT = 1523))(CONNECT_DATA =(SERVER = DEDICATED)(SERVICE_NAME = PROFILO))); User ID=PROFILO_MANTM;Password=PROFILO_MANTM");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:DefaultSchema", "PROFILO_MANTM");

            modelBuilder.Entity<AdminLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ADMIN_LOG");

                entity.Property(e => e.Funzione)
                    .HasColumnName("FUNZIONE")
                    .IsUnicode(false);

                entity.Property(e => e.Log)
                    .HasColumnName("LOG")
                    .IsUnicode(false);

                entity.Property(e => e.Operatore)
                    .HasColumnName("OPERATORE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"Sysdate
");
            });

            modelBuilder.Entity<CalcLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CALC_LOG");

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Appropriatezzaass)
                    .HasColumnName("APPROPRIATEZZAASS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Codsistema)
                    .HasColumnName("CODSISTEMA")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Flagsino)
                    .HasColumnName("FLAGSINO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Irna)
                    .HasColumnName("IRNA")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivi)
                    .HasColumnName("OBIETTIVI")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo1)
                    .HasColumnName("OBIETTIVO1")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo2)
                    .HasColumnName("OBIETTIVO2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Operatore)
                    .HasColumnName("OPERATORE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Operazione)
                    .HasColumnName("OPERAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Patrimonio)
                    .HasColumnName("PATRIMONIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Perc12m)
                    .HasColumnName("PERC12M")
                    .HasColumnType("CHAR(5)");

                entity.Property(e => e.Perc36m)
                    .HasColumnName("PERC36M")
                    .HasColumnType("CHAR(5)");

                entity.Property(e => e.Perc60m)
                    .HasColumnName("PERC60M")
                    .HasColumnType("CHAR(5)");

                entity.Property(e => e.Perc84m)
                    .HasColumnName("PERC84M")
                    .HasColumnType("CHAR(5)");

                entity.Property(e => e.Percmax)
                    .HasColumnName("PERCMAX")
                    .HasColumnType("CHAR(5)");

                entity.Property(e => e.Profsintetico)
                    .HasColumnName("PROFSINTETICO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Rischio)
                    .HasColumnName("RISCHIO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Rischioass)
                    .HasColumnName("RISCHIOASS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Risultatoadeguatezza)
                    .HasColumnName("RISULTATOADEGUATEZZA")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CheckApproLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CHECK_APPRO_LOG");

                entity.Property(e => e.DataInserimento)
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.RisNuovo)
                    .HasColumnName("RIS_NUOVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RisVecchio)
                    .HasColumnName("RIS_VECCHIO")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClasseAttInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSE_ATT_INV");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Immobili)
                    .HasColumnName("IMMOBILI")
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.Patrimonio)
                    .HasColumnName("PATRIMONIO")
                    .HasColumnType("CHAR(3)");
            });

            modelBuilder.Entity<ClasseImpFin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSE_IMP_FIN");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Impegni)
                    .HasColumnName("IMPEGNI")
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.Perdite)
                    .HasColumnName("PERDITE")
                    .HasColumnType("CHAR(3)");
            });

            modelBuilder.Entity<ClasseImpFinPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSE_IMP_FIN_PG");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Impegni)
                    .HasColumnName("IMPEGNI")
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.Perdite)
                    .HasColumnName("PERDITE")
                    .HasColumnType("CHAR(3)");
            });

            modelBuilder.Entity<ClasseRedPatr>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSE_RED_PATR");

                entity.Property(e => e.AttInv)
                    .HasColumnName("ATT_INV")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Reddito)
                    .HasColumnName("REDDITO")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<ClasseRedPatrPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSE_RED_PATR_PG");

                entity.Property(e => e.AttInv)
                    .HasColumnName("ATT_INV")
                    .HasColumnType("CHAR(3)");

                entity.Property(e => e.Punteggio)
                    .HasColumnName("PUNTEGGIO")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Reddito)
                    .HasColumnName("REDDITO")
                    .HasColumnType("CHAR(2)");
            });

            modelBuilder.Entity<ClasseReddito>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSE_REDDITO");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Fonti)
                    .HasColumnName("FONTI")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.Risparmio)
                    .HasColumnName("RISPARMIO")
                    .HasColumnType("CHAR(2)");
            });

            modelBuilder.Entity<ClasseRedditoPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CLASSE_REDDITO_PG");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PatrNetto)
                    .HasColumnName("PATR_NETTO")
                    .HasColumnType("CHAR(2)");

                entity.Property(e => e.SituazEco)
                    .HasColumnName("SITUAZ_ECO")
                    .HasColumnType("CHAR(2)");
            });

            modelBuilder.Entity<ControlloSae>(entity =>
            {
                entity.HasKey(e => new { e.Ciae, e.Sae, e.CodRisposta })
                    .HasName("SYS_C008383");

                entity.ToTable("CONTROLLO_SAE");

                entity.Property(e => e.Ciae)
                    .HasColumnName("CIAE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Sae)
                    .HasColumnName("SAE")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.Anagrafe)
                    .HasColumnName("ANAGRAFE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoClas)
                    .IsRequired()
                    .HasColumnName("TIPO_CLAS")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DescProfTolRischio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DESC_PROF_TOL_RISCHIO");

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfTolRischio)
                    .HasColumnName("PROF_TOL_RISCHIO")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<DescProfTolRischioPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DESC_PROF_TOL_RISCHIO_PG");

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfTolRischioPg)
                    .HasColumnName("PROF_TOL_RISCHIO_PG")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<DescProfiloEsg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DESC_PROFILO_ESG");

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloEsg)
                    .HasColumnName("PROFILO_ESG")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<DescSituazFin>(entity =>
            {
                entity.HasKey(e => e.SituazFin)
                    .HasName("PK_SITUAZ_FIN");

                entity.ToTable("DESC_SITUAZ_FIN");

                entity.Property(e => e.SituazFin)
                    .HasColumnName("SITUAZ_FIN")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EtaDurataInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ETA_DURATA_INV");

                entity.Property(e => e.Attiva)
                    .HasColumnName("ATTIVA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.EtaA).HasColumnName("ETA_A");

                entity.Property(e => e.EtaDa).HasColumnName("ETA_DA");
            });

            modelBuilder.Entity<ExpQuestConsob>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EXP_QUEST_CONSOB");

                entity.Property(e => e.Campo1)
                    .HasColumnName("CAMPO_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo10)
                    .HasColumnName("CAMPO_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo100)
                    .HasColumnName("CAMPO_100")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo101)
                    .HasColumnName("CAMPO_101")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo102)
                    .HasColumnName("CAMPO_102")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo103)
                    .HasColumnName("CAMPO_103")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo104)
                    .HasColumnName("CAMPO_104")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo105)
                    .HasColumnName("CAMPO_105")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo106)
                    .HasColumnName("CAMPO_106")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo107)
                    .HasColumnName("CAMPO_107")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo108)
                    .HasColumnName("CAMPO_108")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo109)
                    .HasColumnName("CAMPO_109")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo11)
                    .HasColumnName("CAMPO_11")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo110)
                    .HasColumnName("CAMPO_110")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo111)
                    .HasColumnName("CAMPO_111")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo112)
                    .HasColumnName("CAMPO_112")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo113)
                    .HasColumnName("CAMPO_113")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo114)
                    .HasColumnName("CAMPO_114")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo115)
                    .HasColumnName("CAMPO_115")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo116)
                    .HasColumnName("CAMPO_116")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo117)
                    .HasColumnName("CAMPO_117")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo118)
                    .HasColumnName("CAMPO_118")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo119)
                    .HasColumnName("CAMPO_119")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo12)
                    .HasColumnName("CAMPO_12")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo120)
                    .HasColumnName("CAMPO_120")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo121)
                    .HasColumnName("CAMPO_121")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo122)
                    .HasColumnName("CAMPO_122")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo123)
                    .HasColumnName("CAMPO_123")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo124)
                    .HasColumnName("CAMPO_124")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo125)
                    .HasColumnName("CAMPO_125")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo126)
                    .HasColumnName("CAMPO_126")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo127)
                    .HasColumnName("CAMPO_127")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo128)
                    .HasColumnName("CAMPO_128")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo129)
                    .HasColumnName("CAMPO_129")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo13)
                    .HasColumnName("CAMPO_13")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo130)
                    .HasColumnName("CAMPO_130")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo131)
                    .HasColumnName("CAMPO_131")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo14)
                    .HasColumnName("CAMPO_14")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo15)
                    .HasColumnName("CAMPO_15")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo16)
                    .HasColumnName("CAMPO_16")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo17)
                    .HasColumnName("CAMPO_17")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo18)
                    .HasColumnName("CAMPO_18")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo19)
                    .HasColumnName("CAMPO_19")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo2)
                    .HasColumnName("CAMPO_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo20)
                    .HasColumnName("CAMPO_20")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo21)
                    .HasColumnName("CAMPO_21")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo22)
                    .HasColumnName("CAMPO_22")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo23)
                    .HasColumnName("CAMPO_23")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo24)
                    .HasColumnName("CAMPO_24")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo25)
                    .HasColumnName("CAMPO_25")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo26)
                    .HasColumnName("CAMPO_26")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo27)
                    .HasColumnName("CAMPO_27")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo28)
                    .HasColumnName("CAMPO_28")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo29)
                    .HasColumnName("CAMPO_29")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo3)
                    .HasColumnName("CAMPO_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo30)
                    .HasColumnName("CAMPO_30")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo31)
                    .HasColumnName("CAMPO_31")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo32)
                    .HasColumnName("CAMPO_32")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo33)
                    .HasColumnName("CAMPO_33")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo34)
                    .HasColumnName("CAMPO_34")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo35)
                    .HasColumnName("CAMPO_35")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo36)
                    .HasColumnName("CAMPO_36")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo37)
                    .HasColumnName("CAMPO_37")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo38)
                    .HasColumnName("CAMPO_38")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo39)
                    .HasColumnName("CAMPO_39")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo4)
                    .HasColumnName("CAMPO_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo40)
                    .HasColumnName("CAMPO_40")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo41)
                    .HasColumnName("CAMPO_41")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo42)
                    .HasColumnName("CAMPO_42")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo43)
                    .HasColumnName("CAMPO_43")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo44)
                    .HasColumnName("CAMPO_44")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo45)
                    .HasColumnName("CAMPO_45")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo46)
                    .HasColumnName("CAMPO_46")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo47)
                    .HasColumnName("CAMPO_47")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo48)
                    .HasColumnName("CAMPO_48")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo49)
                    .HasColumnName("CAMPO_49")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo5)
                    .HasColumnName("CAMPO_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo50)
                    .HasColumnName("CAMPO_50")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo51)
                    .HasColumnName("CAMPO_51")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo52)
                    .HasColumnName("CAMPO_52")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo53)
                    .HasColumnName("CAMPO_53")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo54)
                    .HasColumnName("CAMPO_54")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo55)
                    .HasColumnName("CAMPO_55")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo56)
                    .HasColumnName("CAMPO_56")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo57)
                    .HasColumnName("CAMPO_57")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo58)
                    .HasColumnName("CAMPO_58")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo59)
                    .HasColumnName("CAMPO_59")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo6)
                    .HasColumnName("CAMPO_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo60)
                    .HasColumnName("CAMPO_60")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo61)
                    .HasColumnName("CAMPO_61")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo62)
                    .HasColumnName("CAMPO_62")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo63)
                    .HasColumnName("CAMPO_63")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo64)
                    .HasColumnName("CAMPO_64")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo65)
                    .HasColumnName("CAMPO_65")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo66)
                    .HasColumnName("CAMPO_66")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo67)
                    .HasColumnName("CAMPO_67")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo68)
                    .HasColumnName("CAMPO_68")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo69)
                    .HasColumnName("CAMPO_69")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo7)
                    .HasColumnName("CAMPO_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo70)
                    .HasColumnName("CAMPO_70")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo71)
                    .HasColumnName("CAMPO_71")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo72)
                    .HasColumnName("CAMPO_72")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo73)
                    .HasColumnName("CAMPO_73")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo74)
                    .HasColumnName("CAMPO_74")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo75)
                    .HasColumnName("CAMPO_75")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo76)
                    .HasColumnName("CAMPO_76")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo77)
                    .HasColumnName("CAMPO_77")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo78)
                    .HasColumnName("CAMPO_78")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo79)
                    .HasColumnName("CAMPO_79")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo8)
                    .HasColumnName("CAMPO_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo80)
                    .HasColumnName("CAMPO_80")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo81)
                    .HasColumnName("CAMPO_81")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo82)
                    .HasColumnName("CAMPO_82")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo83)
                    .HasColumnName("CAMPO_83")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo84)
                    .HasColumnName("CAMPO_84")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo85)
                    .HasColumnName("CAMPO_85")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo86)
                    .HasColumnName("CAMPO_86")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo87)
                    .HasColumnName("CAMPO_87")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo88)
                    .HasColumnName("CAMPO_88")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo89)
                    .HasColumnName("CAMPO_89")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo9)
                    .HasColumnName("CAMPO_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo90)
                    .HasColumnName("CAMPO_90")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo91)
                    .HasColumnName("CAMPO_91")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo92)
                    .HasColumnName("CAMPO_92")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo93)
                    .HasColumnName("CAMPO_93")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo94)
                    .HasColumnName("CAMPO_94")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo95)
                    .HasColumnName("CAMPO_95")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo96)
                    .HasColumnName("CAMPO_96")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo97)
                    .HasColumnName("CAMPO_97")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo98)
                    .HasColumnName("CAMPO_98")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Campo99)
                    .HasColumnName("CAMPO_99")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Filiale)
                    .HasColumnName("FILIALE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Ora)
                    .HasColumnName("ORA")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Profilo)
                    .HasColumnName("PROFILO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rischio)
                    .HasColumnName("RISCHIO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Up)
                    .HasColumnName("UP")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Finalita>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINALITA");

                entity.Property(e => e.A).HasColumnType("CHAR(1)");

                entity.Property(e => e.B).HasColumnType("CHAR(1)");

                entity.Property(e => e.C).HasColumnType("CHAR(1)");

                entity.Property(e => e.D).HasColumnType("CHAR(1)");

                entity.Property(e => e.Domord)
                    .HasColumnName("DOMORD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.E).HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<FinalitaPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("FINALITA_PG");

                entity.Property(e => e.A).HasColumnType("CHAR(1)");

                entity.Property(e => e.B).HasColumnType("CHAR(1)");

                entity.Property(e => e.C).HasColumnType("CHAR(1)");

                entity.Property(e => e.D).HasColumnType("CHAR(1)");

                entity.Property(e => e.Domord)
                    .HasColumnName("DOMORD")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.E).HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<LogDatiCalcolo>(entity =>
            {
                entity.HasKey(e => e.CodScheda);

                entity.ToTable("LOG_DATI_CALCOLO");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddendoB).HasColumnName("ADDENDO_B");

                entity.Property(e => e.AddendoBRivalutato).HasColumnName("ADDENDO_B_RIVALUTATO");

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ArPuntiAlta)
                    .HasColumnName("AR_PUNTI_ALTA")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.ArPuntiBassa)
                    .HasColumnName("AR_PUNTI_BASSA")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CampiFonti)
                    .HasColumnName("CAMPI_FONTI")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.CampoHolding)
                    .HasColumnName("CAMPO_HOLDING")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CampoImmobili)
                    .HasColumnName("CAMPO_IMMOBILI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampoImpegni)
                    .HasColumnName("CAMPO_IMPEGNI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampoImpegniPosidonia)
                    .HasColumnName("CAMPO_IMPEGNI_POSIDONIA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampoPatrimonio)
                    .HasColumnName("CAMPO_PATRIMONIO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampoPerdite)
                    .HasColumnName("CAMPO_PERDITE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CampoProfiloRischio)
                    .HasColumnName("CAMPO_PROFILO_RISCHIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CampoRisparmio)
                    .HasColumnName("CAMPO_RISPARMIO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseAttInv)
                    .HasColumnName("CLASSE_ATT_INV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseImpFin)
                    .HasColumnName("CLASSE_IMP_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseR)
                    .HasColumnName("CLASSE_R")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseRedPatr)
                    .HasColumnName("CLASSE_RED_PATR")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ClasseReddito)
                    .HasColumnName("CLASSE_REDDITO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CoefficienteHp1)
                    .HasColumnName("COEFFICIENTE_HP1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CoefficienteHp2)
                    .HasColumnName("COEFFICIENTE_HP2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CoefficienteHp3)
                    .HasColumnName("COEFFICIENTE_HP3")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CoefficienteHp4)
                    .HasColumnName("COEFFICIENTE_HP4")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CoefficienteHp5)
                    .HasColumnName("COEFFICIENTE_HP5")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CombinazRispObiettivo)
                    .HasColumnName("COMBINAZ_RISP_OBIETTIVO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Conoscenza)
                    .HasColumnName("CONOSCENZA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DatiCalcolo)
                    .HasColumnName("DATI_CALCOLO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ElencoCodiciFiscali)
                    .HasColumnName("ELENCO_CODICI_FISCALI")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Esperienza)
                    .HasColumnName("ESPERIENZA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Finalita)
                    .HasColumnName("FINALITA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Holding)
                    .HasColumnName("HOLDING")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ImportoOperazioni)
                    .HasColumnName("IMPORTO_OPERAZIONI")
                    .HasColumnType("NUMBER(15,3)");

                entity.Property(e => e.ImportoOperazioniMedio)
                    .HasColumnName("IMPORTO_OPERAZIONI_MEDIO")
                    .HasColumnType("NUMBER(15,3)");

                entity.Property(e => e.Investimenti)
                    .HasColumnName("INVESTIMENTI")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Listanumopz)
                    .HasColumnName("LISTANUMOPZ")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Listanumopzmin)
                    .HasColumnName("LISTANUMOPZMIN")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumCqsBp)
                    .HasColumnName("NUM_CQS_BP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumMutuiBp)
                    .HasColumnName("NUM_MUTUI_BP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.NumPrestitiBp)
                    .HasColumnName("NUM_PRESTITI_BP")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo)
                    .HasColumnName("OBIETTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PatrimonioBp)
                    .HasColumnName("PATRIMONIO_BP")
                    .HasColumnType("NUMBER(15,3)");

                entity.Property(e => e.Perc12m)
                    .HasColumnName("PERC12M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc36m)
                    .HasColumnName("PERC36M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc60m)
                    .HasColumnName("PERC60M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc84m)
                    .HasColumnName("PERC84M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Percmax)
                    .HasColumnName("PERCMAX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ponderazione)
                    .HasColumnName("PONDERAZIONE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.PreProfilo)
                    .HasColumnName("PRE_PROFILO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloEsg)
                    .HasColumnName("PROFILO_ESG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloFin)
                    .HasColumnName("PROFILO_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloTolRischio)
                    .HasColumnName("PROFILO_TOL_RISCHIO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloTolRischioOrig)
                    .HasColumnName("PROFILO_TOL_RISCHIO_ORIG")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PunteggioInv)
                    .HasColumnName("PUNTEGGIO_INV")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.PunteggioTotale)
                    .HasColumnName("PUNTEGGIO_TOTALE")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Punti11)
                    .HasColumnName("PUNTI11")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Punti11Posidonia)
                    .HasColumnName("PUNTI11_POSIDONIA")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Punti8)
                    .HasColumnName("PUNTI8")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Punti9)
                    .HasColumnName("PUNTI9")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.PuntiNucleoFam)
                    .HasColumnName("PUNTI_NUCLEO_FAM")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Puntidomimp)
                    .HasColumnName("PUNTIDOMIMP")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Puntidominv)
                    .HasColumnName("PUNTIDOMINV")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.RisultatoFinalita)
                    .HasColumnName("RISULTATO_FINALITA")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SituazioneFinanziaria)
                    .HasColumnName("SITUAZIONE_FINANZIARIA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.SommaAddendi)
                    .HasColumnName("SOMMA_ADDENDI")
                    .HasColumnType("NUMBER(15,3)");

                entity.Property(e => e.SommaPunti8911)
                    .HasColumnName("SOMMA_PUNTI_8_9_11")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.TotaleOperazioni)
                    .HasColumnName("TOTALE_OPERAZIONI")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.TotaleProfiloEsg)
                    .HasColumnName("TOTALE_PROFILO_ESG")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogDatiHost>(entity =>
            {
                entity.HasKey(e => new { e.CodScheda, e.Metodo, e.Ndg });

                entity.ToTable("LOG_DATI_HOST");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Metodo)
                    .HasColumnName("METODO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Output)
                    .HasColumnName("OUTPUT")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogSchedeWsf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_SCHEDE_WSF");

                entity.Property(e => e.Causale)
                    .HasColumnName("CAUSALE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodSchedaR)
                    .HasColumnName("COD_SCHEDA_R")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodSchedaU)
                    .HasColumnName("COD_SCHEDA_U")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Codice)
                    .HasColumnName("CODICE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Crf)
                    .HasColumnName("CRF")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataLog)
                    .HasColumnName("DATA_LOG")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasColumnName("MSG")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NomCliente)
                    .HasColumnName("NOM_CLIENTE")
                    .HasMaxLength(75)
                    .IsUnicode(false);

                entity.Property(e => e.NumCc)
                    .HasColumnName("NUM_CC")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumDomanda)
                    .HasColumnName("NUM_DOMANDA")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Regolamento)
                    .HasColumnName("REGOLAMENTO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogSospesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("LOG_SOSPESI");

                entity.Property(e => e.CodSchedaR)
                    .HasColumnName("COD_SCHEDA_R")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodSchedaU)
                    .HasColumnName("COD_SCHEDA_U")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Codice)
                    .HasColumnName("CODICE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DataIns)
                    .HasColumnName("DATA_INS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataLog)
                    .HasColumnName("DATA_LOG")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Metodo)
                    .HasColumnName("METODO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OraIns)
                    .HasColumnName("ORA_INS")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Testo)
                    .HasColumnName("TESTO")
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NdgExport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("NDG_EXPORT");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DataIac)
                    .HasColumnName("DATA_IAC")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Msg)
                    .HasColumnName("MSG")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumRif)
                    .HasColumnName("NUM_RIF")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.OraIac)
                    .HasColumnName("ORA_IAC")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OraIns)
                    .HasColumnName("ORA_INS")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Progr)
                    .HasColumnName("PROGR")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Stato)
                    .HasColumnName("STATO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ObiettivoInv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OBIETTIVO_INV");

                entity.Property(e => e.CombinazioneRisp)
                    .HasColumnName("COMBINAZIONE_RISP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Profilo)
                    .HasColumnName("PROFILO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdineDomUnico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDINE_DOM_UNICO");

                entity.Property(e => e.CodDomandaA).HasColumnName("COD_DOMANDA_A");

                entity.Property(e => e.CodDomandaB).HasColumnName("COD_DOMANDA_B");

                entity.Property(e => e.CodTipoSchedaA)
                    .HasColumnName("COD_TIPO_SCHEDA_A")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodTipoSchedaB)
                    .HasColumnName("COD_TIPO_SCHEDA_B")
                    .HasColumnType("NUMBER(9)");
            });

            modelBuilder.Entity<OrdineRispRic>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDINE_RISP_RIC");

                entity.Property(e => e.CodRispostaA).HasColumnName("COD_RISPOSTA_A");

                entity.Property(e => e.CodRispostaB).HasColumnName("COD_RISPOSTA_B");

                entity.Property(e => e.CodTipoSchedaA)
                    .HasColumnName("COD_TIPO_SCHEDA_A")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodTipoSchedaB)
                    .HasColumnName("COD_TIPO_SCHEDA_B")
                    .HasColumnType("NUMBER(9)");
            });

            modelBuilder.Entity<OrdineRispUnico>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ORDINE_RISP_UNICO");

                entity.Property(e => e.CodRispostaA).HasColumnName("COD_RISPOSTA_A");

                entity.Property(e => e.CodRispostaB).HasColumnName("COD_RISPOSTA_B");

                entity.Property(e => e.CodTipoSchedaA)
                    .HasColumnName("COD_TIPO_SCHEDA_A")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodTipoSchedaB)
                    .HasColumnName("COD_TIPO_SCHEDA_B")
                    .HasColumnType("NUMBER(9)");
            });

            modelBuilder.Entity<PreProf>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRE_PROF");

                entity.Property(e => e.Finalita)
                    .HasColumnName("FINALITA")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Punteggio)
                    .HasColumnName("PUNTEGGIO")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Rischio)
                    .HasColumnName("RISCHIO")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<PreProfPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PRE_PROF_PG");

                entity.Property(e => e.Holding)
                    .HasColumnName("HOLDING")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Punteggio)
                    .HasColumnName("PUNTEGGIO")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.Rischio)
                    .HasColumnName("RISCHIO")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<ProfiloFinanziario>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROFILO_FINANZIARIO");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.ImpFin)
                    .HasColumnName("IMP_FIN")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.RedPatr)
                    .HasColumnName("RED_PATR")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<ProfiloFinanziarioPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROFILO_FINANZIARIO_PG");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.ImpFin)
                    .HasColumnName("IMP_FIN")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.RedPatr)
                    .HasColumnName("RED_PATR")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<ProfiloTolRischio>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROFILO_TOL_RISCHIO");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PreProf)
                    .HasColumnName("PRE_PROF")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.ProfFin)
                    .HasColumnName("PROF_FIN")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<ProfiloTolRischioPg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("PROFILO_TOL_RISCHIO_PG");

                entity.Property(e => e.Classe)
                    .HasColumnName("CLASSE")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.PreProf)
                    .HasColumnName("PRE_PROF")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.ProfFin)
                    .HasColumnName("PROF_FIN")
                    .HasColumnType("CHAR(1)");
            });

            modelBuilder.Entity<RangeDomande>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RANGE_DOMANDE");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Punteggio)
                    .HasColumnName("PUNTEGGIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ValoreA)
                    .HasColumnName("VALORE_A")
                    .HasColumnType("NUMBER(12)");

                entity.Property(e => e.ValoreDa)
                    .HasColumnName("VALORE_DA")
                    .HasColumnType("NUMBER(9)");
            });

            modelBuilder.Entity<TbClassificazione>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_CLASSIFICAZIONE");

                entity.HasIndex(e => new { e.Ndg, e.TipoClassificazione, e.Data })
                    .HasName("TB_CLASSIFICAZIONE_PK")
                    .IsUnique();

                entity.Property(e => e.Data)
                    .IsRequired()
                    .HasColumnName("DATA")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("Sysdate               ");

                entity.Property(e => e.DescrClassificazione)
                    .HasColumnName("DESCR_CLASSIFICAZIONE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndicatoreFuoriSede)
                    .HasColumnName("INDICATORE_FUORI_SEDE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"'N'
");

                entity.Property(e => e.Ndg)
                    .IsRequired()
                    .HasColumnName("NDG")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Operatore)
                    .HasColumnName("OPERATORE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoClassificazione)
                    .IsRequired()
                    .HasColumnName("TIPO_CLASSIFICAZIONE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbDescrSezioneDomande>(entity =>
            {
                entity.HasKey(e => new { e.Sezione, e.CodTipoScheda })
                    .HasName("PK_DESCR_SEZIONE");

                entity.ToTable("TB_DESCR_SEZIONE_DOMANDE");

                entity.Property(e => e.Sezione)
                    .HasColumnName("SEZIONE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Descrizione)
                    .IsRequired()
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbDomande>(entity =>
            {
                entity.HasKey(e => new { e.CodDomanda, e.CodTipoScheda, e.DataScadenza })
                    .HasName("SYS_C008404");

                entity.ToTable("TB_DOMANDE");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Adeguatezza)
                    .HasColumnName("ADEGUATEZZA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bloccante)
                    .HasColumnName("BLOCCANTE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CodDomandaPadre).HasColumnName("COD_DOMANDA_PADRE");

                entity.Property(e => e.DescPosizione)
                    .HasColumnName("DESC_POSIZIONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescPosizioneFe)
                    .HasColumnName("DESC_POSIZIONE_FE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescrAggiuntiva)
                    .HasColumnName("DESCR_AGGIUNTIVA")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DescrTooltip)
                    .HasColumnName("DESCR_TOOLTIP")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EspCon)
                    .HasColumnName("ESP_CON")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Info)
                    .HasColumnName("INFO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Layout)
                    .HasColumnName("LAYOUT")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Modulo)
                    .HasColumnName("MODULO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Multirisposta)
                    .HasColumnName("MULTIRISPOSTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nota)
                    .HasColumnName("NOTA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NumRisposte)
                    .HasColumnName("NUM_RISPOSTE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Obbligatoria)
                    .HasColumnName("OBBLIGATORIA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ordine)
                    .HasColumnName("ORDINE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Peso)
                    .HasColumnName("PESO")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Sezione)
                    .HasColumnName("SEZIONE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Titolo)
                    .HasColumnName("TITOLO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbErroriVincoli>(entity =>
            {
                entity.HasKey(e => e.CodScheda);

                entity.ToTable("TB_ERRORI_VINCOLI");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.MsgErrore)
                    .HasColumnName("MSG_ERRORE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Operatore)
                    .HasColumnName("OPERATORE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Ora)
                    .HasColumnName("ORA")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RispDomA)
                    .HasColumnName("RISP_DOM_A")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RispDomB)
                    .HasColumnName("RISP_DOM_B")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbIndirizziEmail>(entity =>
            {
                entity.HasKey(e => new { e.CodScheda, e.NdgRapp, e.Cf })
                    .HasName("PK_INDIRIZZI_EMAIL");

                entity.ToTable("TB_INDIRIZZI_EMAIL");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.NdgRapp)
                    .HasColumnName("NDG_RAPP")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cf)
                    .HasColumnName("CF")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("EMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDoc)
                    .IsRequired()
                    .HasColumnName("TIPO_DOC")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbIntestazioni>(entity =>
            {
                entity.HasKey(e => new { e.TipoScheda, e.CodDomanda, e.CodRisposta });

                entity.ToTable("TB_INTESTAZIONI");

                entity.HasIndex(e => e.TipoScheda)
                    .HasName("TIPOSCH_IDX_001");

                entity.Property(e => e.TipoScheda)
                    .HasColumnName("TIPO_SCHEDA")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.OrdineDomanda)
                    .HasColumnName("ORDINE_DOMANDA")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.OrdineRisposta)
                    .HasColumnName("ORDINE_RISPOSTA")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Progressivo).HasColumnName("PROGRESSIVO");

                entity.Property(e => e.Testo)
                    .HasColumnName("TESTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_LOG");

                entity.Property(e => e.NCodIntervista)
                    .HasColumnName("N_COD_INTERVISTA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.NCodNdg)
                    .HasColumnName("N_COD_NDG")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NCodQuestionario)
                    .HasColumnName("N_COD_QUESTIONARIO")
                    .HasColumnType("NUMBER(8)");

                entity.Property(e => e.NCodRapporto)
                    .HasColumnName("N_COD_RAPPORTO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NCodServizio)
                    .HasColumnName("N_COD_SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SCatRapporto)
                    .HasColumnName("S_CAT_RAPPORTO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SData)
                    .HasColumnName("S_DATA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SFrazionario)
                    .HasColumnName("S_FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SOperazione)
                    .HasColumnName("S_OPERAZIONE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SOra)
                    .HasColumnName("S_ORA")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.STerminale)
                    .HasColumnName("S_TERMINALE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbObiettivi>(entity =>
            {
                entity.HasKey(e => new { e.CodProdotto, e.Obiettivo })
                    .HasName("SYS_C008413");

                entity.ToTable("TB_OBIETTIVI");

                entity.Property(e => e.CodProdotto)
                    .HasColumnName("COD_PRODOTTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo)
                    .HasColumnName("OBIETTIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbObiettiviPg>(entity =>
            {
                entity.HasKey(e => new { e.CodProdotto, e.Obiettivo })
                    .HasName("SYS_C008416");

                entity.ToTable("TB_OBIETTIVI_PG");

                entity.Property(e => e.CodProdotto)
                    .HasColumnName("COD_PRODOTTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo)
                    .HasColumnName("OBIETTIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbParametro>(entity =>
            {
                entity.HasKey(e => new { e.NumGiorni, e.DataInizio, e.DataFine });

                entity.ToTable("TB_PARAMETRO");

                entity.Property(e => e.NumGiorni)
                    .HasColumnName("NUM_GIORNI")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DataInizio)
                    .HasColumnName("DATA_INIZIO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataFine)
                    .HasColumnName("DATA_FINE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Valore)
                    .HasColumnName("VALORE")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProfiliScheda>(entity =>
            {
                entity.HasKey(e => e.SCodProfilo)
                    .HasName("SYS_C008418");

                entity.ToTable("TB_PROFILI_SCHEDA");

                entity.Property(e => e.SCodProfilo)
                    .HasColumnName("S_COD_PROFILO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NRangeA).HasColumnName("N_RANGE_A");

                entity.Property(e => e.NRangeDa).HasColumnName("N_RANGE_DA");

                entity.Property(e => e.SDescrizione)
                    .HasColumnName("S_DESCRIZIONE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbProgressivi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_PROGRESSIVI");

                entity.Property(e => e.NNumero)
                    .HasColumnName("N_NUMERO")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.SProgressivo)
                    .HasColumnName("S_PROGRESSIVO")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbRisposte>(entity =>
            {
                entity.HasKey(e => new { e.CodRisposta, e.CodDomanda, e.CodTipoScheda })
                    .HasName("SYS_C008423");

                entity.ToTable("TB_RISPOSTE");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Bloccante)
                    .HasColumnName("BLOCCANTE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .IsRequired()
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DescPosizione)
                    .HasColumnName("DESC_POSIZIONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DescPosizioneFe)
                    .HasColumnName("DESC_POSIZIONE_FE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ordine)
                    .HasColumnName("ORDINE")
                    .HasColumnType("NUMBER(2)");

                entity.Property(e => e.Punteggio)
                    .HasColumnName("PUNTEGGIO")
                    .HasColumnType("NUMBER(6,2)");

                entity.Property(e => e.Titolo)
                    .HasColumnName("TITOLO")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbRisposteSRic>(entity =>
            {
                entity.HasKey(e => new { e.CodScheda, e.CodDomanda, e.CodRisposta })
                    .HasName("PK_TB_RISPOSTE_RIC");

                entity.ToTable("TB_RISPOSTE_S_RIC");

                entity.HasIndex(e => e.CodScheda)
                    .HasName("CODSR_IDX_001");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.Scelta)
                    .HasColumnName("SCELTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbRisposteScheda>(entity =>
            {
                entity.HasKey(e => new { e.CodScheda, e.CodDomanda, e.CodRisposta })
                    .HasName("PK_TB_RISPOSTE_CONSOB");

                entity.ToTable("TB_RISPOSTE_SCHEDA");

                entity.HasIndex(e => e.CodScheda)
                    .HasName("CODSU_IDX_001");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.Scelta)
                    .HasColumnName("SCELTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbRisposteSchedaCl>(entity =>
            {
                entity.HasKey(e => new { e.CodScheda, e.CodDomanda, e.CodRisposta });

                entity.ToTable("TB_RISPOSTE_SCHEDA_CL");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.Scelta)
                    .HasColumnName("SCELTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodSchedaNavigation)
                    .WithMany(p => p.TbRisposteSchedaCl)
                    .HasForeignKey(d => d.CodScheda)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SYS_C008494");
            });

            modelBuilder.Entity<TbSchedaCl>(entity =>
            {
                entity.HasKey(e => e.CodSchedaCl);

                entity.ToTable("TB_SCHEDA_CL");

                entity.Property(e => e.CodSchedaCl)
                    .HasColumnName("COD_SCHEDA_CL")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataInserimento)
                    .IsRequired()
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .IsRequired()
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivo)
                    .HasColumnName("PROGRESSIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .IsRequired()
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoColl)
                    .HasColumnName("TIPO_COLL")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSchedaRicorrente>(entity =>
            {
                entity.HasKey(e => e.CodSchedaRicorrente)
                    .HasName("SYS_C008447");

                entity.ToTable("TB_SCHEDA_RICORRENTE");

                entity.HasIndex(e => e.Ndg)
                    .HasName("NDGR_IDX_001");

                entity.Property(e => e.CodSchedaRicorrente)
                    .HasColumnName("COD_SCHEDA_RICORRENTE")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodProdotto)
                    .HasColumnName("COD_PRODOTTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataAttivazione)
                    .HasColumnName("DATA_ATTIVAZIONE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .IsRequired()
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DenominazioneUp)
                    .HasColumnName("DENOMINAZIONE_UP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescrProdotto)
                    .HasColumnName("DESCR_PRODOTTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Matricola)
                    .HasColumnName("MATRICOLA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .IsRequired()
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NucleoFam)
                    .HasColumnName("NUCLEO_FAM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumConsulenza)
                    .HasColumnName("NUM_CONSULENZA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumRelazione)
                    .HasColumnName("NUM_RELAZIONE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo)
                    .HasColumnName("OBIETTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo2)
                    .HasColumnName("OBIETTIVO2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivo)
                    .HasColumnName("PROGRESSIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .IsRequired()
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Sospeso)
                    .HasColumnName("SOSPESO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoQuest)
                    .HasColumnName("TIPO_QUEST")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSchedaUnico>(entity =>
            {
                entity.HasKey(e => e.CodSchedaUnico)
                    .HasName("PK_TB_SCHEDA_CONSOB");

                entity.ToTable("TB_SCHEDA_UNICO");

                entity.HasIndex(e => e.Ndg)
                    .HasName("NDG_IDX_001");

                entity.HasIndex(e => new { e.Ndg, e.DataInserimento, e.OraInserimento })
                    .HasName("IDX_TB_SCHEDA_UNICO")
                    .IsUnique();

                entity.Property(e => e.CodSchedaUnico)
                    .HasColumnName("COD_SCHEDA_UNICO")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adeguatezza)
                    .HasColumnName("ADEGUATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataAttivazione)
                    .HasColumnName("DATA_ATTIVAZIONE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataDomandeScadute)
                    .HasColumnName("DATA_DOMANDE_SCADUTE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .IsRequired()
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DenominazioneUp)
                    .HasColumnName("DENOMINAZIONE_UP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescrProdotto)
                    .HasColumnName("DESCR_PRODOTTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeAggiornate)
                    .HasColumnName("DOMANDE_AGGIORNATE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeScadute)
                    .HasColumnName("DOMANDE_SCADUTE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Matricola)
                    .HasColumnName("MATRICOLA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .IsRequired()
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumConsulenza)
                    .HasColumnName("NUM_CONSULENZA")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo1)
                    .HasColumnName("OBIETTIVO1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ObiettivoInvestimenti)
                    .HasColumnName("OBIETTIVO_INVESTIMENTI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrizzonteTemp)
                    .HasColumnName("ORIZZONTE_TEMP")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.PreferenzeEsg)
                    .HasColumnName("PREFERENZE_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloEsg)
                    .HasColumnName("PROFILO_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloFin)
                    .HasColumnName("PROFILO_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivo)
                    .HasColumnName("PROGRESSIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .IsRequired()
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SituazFin)
                    .HasColumnName("SITUAZ_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sospeso)
                    .HasColumnName("SOSPESO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoColl)
                    .HasColumnName("TIPO_COLL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoQuest)
                    .HasColumnName("TIPO_QUEST")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSchedaUnicoNew>(entity =>
            {
                entity.HasKey(e => new { e.CodSchedaUnico, e.Ndg })
                    .HasName("TB_SCHEDA_UNICO_NEW_PK");

                entity.ToTable("TB_SCHEDA_UNICO_NEW");

                entity.Property(e => e.CodSchedaUnico)
                    .HasColumnName("COD_SCHEDA_UNICO")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Adeguatezza)
                    .HasColumnName("ADEGUATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataAttivazione)
                    .HasColumnName("DATA_ATTIVAZIONE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DenominazioneUp)
                    .HasColumnName("DENOMINAZIONE_UP")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DescrProdotto)
                    .HasColumnName("DESCR_PRODOTTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeAggiornate)
                    .HasColumnName("DOMANDE_AGGIORNATE")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Matricola)
                    .HasColumnName("MATRICOLA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NumConsulenza)
                    .HasColumnName("NUM_CONSULENZA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo1)
                    .HasColumnName("OBIETTIVO1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ObiettivoInvestimenti)
                    .HasColumnName("OBIETTIVO_INVESTIMENTI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrizzonteTemp)
                    .HasColumnName("ORIZZONTE_TEMP")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.PreferenzeEsg)
                    .HasColumnName("PREFERENZE_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloFin)
                    .HasColumnName("PROFILO_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivo)
                    .HasColumnName("PROGRESSIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SituazFin)
                    .HasColumnName("SITUAZ_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sospeso)
                    .HasColumnName("SOSPESO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoColl)
                    .HasColumnName("TIPO_COLL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoQuest)
                    .HasColumnName("TIPO_QUEST")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'A'");
            });

            modelBuilder.Entity<TbServizi>(entity =>
            {
                entity.HasKey(e => e.CodServizio)
                    .HasName("SYS_C008455");

                entity.ToTable("TB_SERVIZI");

                entity.Property(e => e.CodServizio)
                    .HasColumnName("COD_SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSospesi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_SOSPESI");

                entity.Property(e => e.Adeguatezza)
                    .HasColumnName("ADEGUATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodProdotto)
                    .HasColumnName("COD_PRODOTTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodSchedaR)
                    .HasColumnName("COD_SCHEDA_R")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodSchedaU)
                    .HasColumnName("COD_SCHEDA_U")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataAttivazione)
                    .HasColumnName("DATA_ATTIVAZIONE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataDomandeScadute)
                    .HasColumnName("DATA_DOMANDE_SCADUTE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DenominazioneUp)
                    .HasColumnName("DENOMINAZIONE_UP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescrProdotto)
                    .HasColumnName("DESCR_PRODOTTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeAggiornate)
                    .HasColumnName("DOMANDE_AGGIORNATE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeScadute)
                    .HasColumnName("DOMANDE_SCADUTE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Matricola)
                    .HasColumnName("MATRICOLA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .IsRequired()
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NucleoFam)
                    .HasColumnName("NUCLEO_FAM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumConsulenza)
                    .HasColumnName("NUM_CONSULENZA")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NumRelazione)
                    .HasColumnName("NUM_RELAZIONE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo)
                    .HasColumnName("OBIETTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo1)
                    .HasColumnName("OBIETTIVO1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo2)
                    .HasColumnName("OBIETTIVO2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ObiettivoInvestimenti)
                    .HasColumnName("OBIETTIVO_INVESTIMENTI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Operatore)
                    .HasColumnName("OPERATORE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrizzonteTemp)
                    .HasColumnName("ORIZZONTE_TEMP")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.Perc12m)
                    .HasColumnName("PERC12M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc36m)
                    .HasColumnName("PERC36M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc60m)
                    .HasColumnName("PERC60M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc84m)
                    .HasColumnName("PERC84M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Percmax)
                    .HasColumnName("PERCMAX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PreferenzeEsg)
                    .HasColumnName("PREFERENZE_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloEsg)
                    .HasColumnName("PROFILO_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloFin)
                    .HasColumnName("PROFILO_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressivoR)
                    .HasColumnName("PROGRESSIVO_R")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressivoU)
                    .HasColumnName("PROGRESSIVO_U")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SituazFin)
                    .HasColumnName("SITUAZ_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoColl)
                    .HasColumnName("TIPO_COLL")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbSospesiMfm>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_SOSPESI_MFM");

                entity.Property(e => e.Adeguatezza)
                    .HasColumnName("ADEGUATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodProdotto)
                    .HasColumnName("COD_PRODOTTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodSchedaR)
                    .HasColumnName("COD_SCHEDA_R")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodSchedaU)
                    .HasColumnName("COD_SCHEDA_U")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataDomandeScadute)
                    .HasColumnName("DATA_DOMANDE_SCADUTE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DenominazioneUp)
                    .HasColumnName("DENOMINAZIONE_UP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescrProdotto)
                    .HasColumnName("DESCR_PRODOTTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeAggiornate)
                    .HasColumnName("DOMANDE_AGGIORNATE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeScadute)
                    .HasColumnName("DOMANDE_SCADUTE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Matricola)
                    .HasColumnName("MATRICOLA")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .IsRequired()
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NucleoFam)
                    .HasColumnName("NUCLEO_FAM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumConsulenza)
                    .HasColumnName("NUM_CONSULENZA")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NumRelazione)
                    .HasColumnName("NUM_RELAZIONE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo)
                    .HasColumnName("OBIETTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo1)
                    .HasColumnName("OBIETTIVO1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo2)
                    .HasColumnName("OBIETTIVO2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ObiettivoInvestimenti)
                    .HasColumnName("OBIETTIVO_INVESTIMENTI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Operatore)
                    .HasColumnName("OPERATORE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrizzonteTemp)
                    .HasColumnName("ORIZZONTE_TEMP")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.Perc12m)
                    .HasColumnName("PERC12M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc36m)
                    .HasColumnName("PERC36M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc60m)
                    .HasColumnName("PERC60M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Perc84m)
                    .HasColumnName("PERC84M")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Percmax)
                    .HasColumnName("PERCMAX")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PreferenzeEsg)
                    .HasColumnName("PREFERENZE_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloEsg)
                    .HasColumnName("PROFILO_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloFin)
                    .HasColumnName("PROFILO_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressivoR)
                    .HasColumnName("PROGRESSIVO_R")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressivoU)
                    .HasColumnName("PROGRESSIVO_U")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SituazFin)
                    .HasColumnName("SITUAZ_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoColl)
                    .HasColumnName("TIPO_COLL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoQuest)
                    .HasColumnName("TIPO_QUEST")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStatoIntervista>(entity =>
            {
                entity.HasKey(e => e.SCodStatoIntervista)
                    .HasName("SYS_C008461");

                entity.ToTable("TB_STATO_INTERVISTA");

                entity.Property(e => e.SCodStatoIntervista)
                    .HasColumnName("S_COD_STATO_INTERVISTA")
                    .HasColumnType("CHAR(1)");

                entity.Property(e => e.SDescrizione)
                    .HasColumnName("S_DESCRIZIONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStoricoClassificazione>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_STORICO_CLASSIFICAZIONE");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DataStorico)
                    .HasColumnName("DATA_STORICO")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("Sysdate");

                entity.Property(e => e.DescrClassificazione)
                    .HasColumnName("DESCR_CLASSIFICAZIONE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IndicatoreFuoriSede)
                    .HasColumnName("INDICATORE_FUORI_SEDE")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql(@"'N'
");

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Operatore)
                    .HasColumnName("OPERATORE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.TipoClassificazione)
                    .HasColumnName("TIPO_CLASSIFICAZIONE")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStoricoRicorrente>(entity =>
            {
                entity.HasKey(e => e.CodSchedaRicorrente)
                    .HasName("SYS_C008468");

                entity.ToTable("TB_STORICO_RICORRENTE");

                entity.HasIndex(e => e.DataInserimento)
                    .HasName("STORICO_RICORRENTE_DT_INS");

                entity.Property(e => e.CodSchedaRicorrente)
                    .HasColumnName("COD_SCHEDA_RICORRENTE")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodProdotto)
                    .HasColumnName("COD_PRODOTTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataAttivazione)
                    .HasColumnName("DATA_ATTIVAZIONE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .IsRequired()
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataStorico)
                    .IsRequired()
                    .HasColumnName("DATA_STORICO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .IsRequired()
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NucleoFam)
                    .HasColumnName("NUCLEO_FAM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumRelazione)
                    .HasColumnName("NUM_RELAZIONE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo)
                    .HasColumnName("OBIETTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo2)
                    .HasColumnName("OBIETTIVO2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivo)
                    .HasColumnName("PROGRESSIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .IsRequired()
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Sospeso)
                    .HasColumnName("SOSPESO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoQuest)
                    .HasColumnName("TIPO_QUEST")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStoricoRicorrenteBackup>(entity =>
            {
                entity.HasKey(e => e.CodSchedaRicorrente)
                    .HasName("SYS_C0016732");

                entity.ToTable("TB_STORICO_RICORRENTE_BACKUP");

                entity.HasIndex(e => e.Ndg)
                    .HasName("TB_STORICO_RIC_BACKUP$NDG");

                entity.Property(e => e.CodSchedaRicorrente)
                    .HasColumnName("COD_SCHEDA_RICORRENTE")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodProdotto)
                    .HasColumnName("COD_PRODOTTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataAttivazione)
                    .HasColumnName("DATA_ATTIVAZIONE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataStorico)
                    .HasColumnName("DATA_STORICO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NucleoFam)
                    .HasColumnName("NUCLEO_FAM")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NumRelazione)
                    .HasColumnName("NUM_RELAZIONE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo)
                    .HasColumnName("OBIETTIVO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo2)
                    .HasColumnName("OBIETTIVO2")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivo)
                    .HasColumnName("PROGRESSIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Sospeso)
                    .HasColumnName("SOSPESO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoQuest)
                    .HasColumnName("TIPO_QUEST")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'A'");
            });

            modelBuilder.Entity<TbStoricoRisRicBackup>(entity =>
            {
                entity.HasKey(e => new { e.CodScheda, e.CodDomanda, e.CodRisposta })
                    .HasName("PK_TB_RIS_ST_RIC_BCK");

                entity.ToTable("TB_STORICO_RIS_RIC_BACKUP");

                entity.HasIndex(e => e.CodScheda)
                    .HasName("RISP_IDX_BKP");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.Scelta)
                    .HasColumnName("SCELTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStoricoRisUBackup>(entity =>
            {
                entity.HasKey(e => new { e.CodScheda, e.CodDomanda, e.CodRisposta })
                    .HasName("PK_TB_STO_RIS_U_BKP");

                entity.ToTable("TB_STORICO_RIS_U_BACKUP");

                entity.HasIndex(e => e.CodScheda)
                    .HasName("CODSTU_IDX_BKP");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.Scelta)
                    .HasColumnName("SCELTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStoricoRisposteSRic>(entity =>
            {
                entity.HasKey(e => new { e.CodScheda, e.CodDomanda, e.CodRisposta })
                    .HasName("PK_TB_RISPOSTE_ST_RIC");

                entity.ToTable("TB_STORICO_RISPOSTE_S_RIC");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.Scelta)
                    .HasColumnName("SCELTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStoricoRisposteScheda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_STORICO_RISPOSTE_SCHEDA");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.CodScheda)
                    .HasColumnName("COD_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Scelta)
                    .HasColumnName("SCELTA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Temp)
                    .HasColumnName("TEMP")
                    .HasColumnType("NUMBER(2)");
            });

            modelBuilder.Entity<TbStoricoUnico>(entity =>
            {
                entity.HasKey(e => e.CodSchedaUnico)
                    .HasName("PK_TB_STORICO_CONSOB");

                entity.ToTable("TB_STORICO_UNICO");

                entity.HasIndex(e => e.DataInserimento)
                    .HasName("STORICO_UNICO_DT_INS");

                entity.HasIndex(e => new { e.Ndg, e.DataInserimento, e.OraInserimento })
                    .HasName("IDX_TB_STORICO_UNICO")
                    .IsUnique();

                entity.Property(e => e.CodSchedaUnico)
                    .HasColumnName("COD_SCHEDA_UNICO")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adeguatezza)
                    .HasColumnName("ADEGUATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataAttivazione)
                    .HasColumnName("DATA_ATTIVAZIONE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataDomandeScadute)
                    .HasColumnName("DATA_DOMANDE_SCADUTE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .IsRequired()
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataStorico)
                    .IsRequired()
                    .HasColumnName("DATA_STORICO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeScadute)
                    .HasColumnName("DOMANDE_SCADUTE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .IsRequired()
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo1)
                    .HasColumnName("OBIETTIVO1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ObiettivoInvestimenti)
                    .HasColumnName("OBIETTIVO_INVESTIMENTI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrizzonteTemp)
                    .HasColumnName("ORIZZONTE_TEMP")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.PreferenzeEsg)
                    .HasColumnName("PREFERENZE_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloEsg)
                    .HasColumnName("PROFILO_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloFin)
                    .HasColumnName("PROFILO_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivo)
                    .HasColumnName("PROGRESSIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .IsRequired()
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SituazFin)
                    .HasColumnName("SITUAZ_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sospeso)
                    .HasColumnName("SOSPESO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoColl)
                    .HasColumnName("TIPO_COLL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoQuest)
                    .HasColumnName("TIPO_QUEST")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbStoricoUnicoBackup>(entity =>
            {
                entity.HasKey(e => e.CodSchedaUnico)
                    .HasName("PK_TB_STORICO_BKP");

                entity.ToTable("TB_STORICO_UNICO_BACKUP");

                entity.HasIndex(e => e.DataInserimento)
                    .HasName("STORICO_UNICO_BKP_IDX");

                entity.HasIndex(e => e.Ndg)
                    .HasName("TB_STOR_U_BACKUP$NDG");

                entity.Property(e => e.CodSchedaUnico)
                    .HasColumnName("COD_SCHEDA_UNICO")
                    .HasColumnType("NUMBER(9)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adeguatezza)
                    .HasColumnName("ADEGUATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Appropriatezza)
                    .HasColumnName("APPROPRIATEZZA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.DataAttivazione)
                    .HasColumnName("DATA_ATTIVAZIONE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataInserimento)
                    .HasColumnName("DATA_INSERIMENTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataStorico)
                    .HasColumnName("DATA_STORICO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Dichiarazione)
                    .HasColumnName("DICHIARAZIONE")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DomandeScadute)
                    .HasColumnName("DOMANDE_SCADUTE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Eta)
                    .HasColumnName("ETA")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Frazionario)
                    .HasColumnName("FRAZIONARIO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Ndg)
                    .HasColumnName("NDG")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.NdgOperante)
                    .HasColumnName("NDG_OPERANTE")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Obiettivo1)
                    .HasColumnName("OBIETTIVO1")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ObiettivoInvestimenti)
                    .HasColumnName("OBIETTIVO_INVESTIMENTI")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.OraInserimento)
                    .HasColumnName("ORA_INSERIMENTO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.OrizzonteTemp)
                    .HasColumnName("ORIZZONTE_TEMP")
                    .HasColumnType("NUMBER(3,1)");

                entity.Property(e => e.PreferenzeEsg)
                    .HasColumnName("PREFERENZE_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloEsg)
                    .HasColumnName("PROFILO_ESG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProfiloFin)
                    .HasColumnName("PROFILO_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Progressivo)
                    .HasColumnName("PROGRESSIVO")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Rapporto)
                    .HasColumnName("RAPPORTO")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Servizio)
                    .HasColumnName("SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.SituazFin)
                    .HasColumnName("SITUAZ_FIN")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sospeso)
                    .HasColumnName("SOSPESO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Terminale)
                    .HasColumnName("TERMINALE")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TipoColl)
                    .HasColumnName("TIPO_COLL")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoQuest)
                    .HasColumnName("TIPO_QUEST")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'A'");
            });

            modelBuilder.Entity<TbTipoScheda>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TB_TIPO_SCHEDA");

                entity.HasIndex(e => new { e.CodTipoScheda, e.CodServizio, e.RetCode, e.CodProdotto, e.TipoNdg })
                    .HasName("SYS_C001817")
                    .IsUnique();

                entity.Property(e => e.CodProdotto)
                    .HasColumnName("COD_PRODOTTO")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodServizio)
                    .HasColumnName("COD_SERVIZIO")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RetCode)
                    .HasColumnName("RET_CODE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoNdg)
                    .HasColumnName("TIPO_NDG")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Versione)
                    .HasColumnName("VERSIONE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.CodServizioNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.CodServizio)
                    .HasConstraintName("SYS_C008495");
            });

            modelBuilder.Entity<TbUp>(entity =>
            {
                entity.HasKey(e => e.Up);

                entity.ToTable("TB_UP");

                entity.Property(e => e.Up)
                    .HasColumnName("UP")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("COUNTRY")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Descrizione)
                    .HasColumnName("DESCRIZIONE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Provincia)
                    .HasColumnName("PROVINCIA")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbUpFiltro>(entity =>
            {
                entity.HasKey(e => e.Up);

                entity.ToTable("TB_UP_FILTRO");

                entity.Property(e => e.Up)
                    .HasColumnName("UP")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TbVincoliCoerenzaDomande>(entity =>
            {
                entity.HasKey(e => new { e.CodDomanda, e.CodTipoScheda, e.CodRisposta })
                    .HasName("PK_VINCOLI_DOMANDE");

                entity.ToTable("TB_VINCOLI_COERENZA_DOMANDE");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodRisposta)
                    .HasColumnName("COD_RISPOSTA")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtaMax).HasColumnName("ETA_MAX");

                entity.Property(e => e.Messaggio)
                    .HasColumnName("MESSAGGIO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MsgErrore)
                    .HasColumnName("MSG_ERRORE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VincoloBackend)
                    .HasColumnName("VINCOLO_BACKEND")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");
            });

            modelBuilder.Entity<TbVincoliCoerenzaRisposte>(entity =>
            {
                entity.HasKey(e => new { e.CodDomanda, e.CodTipoScheda, e.CodRisposta, e.CodRispostaVincolata })
                    .HasName("PK_VINCOLI_RISPOSTE");

                entity.ToTable("TB_VINCOLI_COERENZA_RISPOSTE");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.CodRispostaVincolata)
                    .HasColumnName("COD_RISPOSTA_VINCOLATA")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtaMax).HasColumnName("ETA_MAX");

                entity.Property(e => e.Messaggio)
                    .HasColumnName("MESSAGGIO")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.MsgErrore)
                    .HasColumnName("MSG_ERRORE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RispSelezionabile)
                    .HasColumnName("RISP_SELEZIONABILE")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'S'");

                entity.Property(e => e.TipoVincolo)
                    .HasColumnName("TIPO_VINCOLO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VincoloBackend)
                    .HasColumnName("VINCOLO_BACKEND")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("'N'");
            });

            modelBuilder.Entity<UtenzeAdmin>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("UTENZE_ADMIN");

                entity.Property(e => e.NomeUtenza)
                    .HasColumnName("NOME_UTENZA")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValoriRisposte>(entity =>
            {
                entity.HasKey(e => new { e.CodTipoScheda, e.CodDomanda, e.CodRisposta });

                entity.ToTable("VALORI_RISPOSTE");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER(9)");

                entity.Property(e => e.CodDomanda).HasColumnName("COD_DOMANDA");

                entity.Property(e => e.CodRisposta).HasColumnName("COD_RISPOSTA");

                entity.Property(e => e.Valore)
                    .HasColumnName("VALORE")
                    .HasColumnType("NUMBER(9)");
            });

            modelBuilder.Entity<VersioniQuestionario>(entity =>
            {
                entity.HasKey(e => new { e.Versione, e.CodTipoScheda });

                entity.ToTable("VERSIONI_QUESTIONARIO");

                entity.Property(e => e.Versione)
                    .HasColumnName("VERSIONE")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.CodTipoScheda)
                    .HasColumnName("COD_TIPO_SCHEDA")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.DataDecorrenza)
                    .HasColumnName("DATA_DECORRENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataScadenza)
                    .HasColumnName("DATA_SCADENZA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ScadenzaQuestionari)
                    .HasColumnName("SCADENZA_QUESTIONARI")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoNdg)
                    .HasColumnName("TIPO_NDG")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WebServiceLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WEB_SERVICE_LOG");

                entity.Property(e => e.Data)
                    .HasColumnName("DATA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("NUMBER");

                entity.Property(e => e.Metodo)
                    .HasColumnName("METODO")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ora)
                    .HasColumnName("ORA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TempoEsecuzione)
                    .HasColumnName("TEMPO_ESECUZIONE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql("Sysdate");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Xml)
                    .HasColumnName("XML")
                    .HasColumnType("CLOB");
            });

            modelBuilder.Entity<WebStringhe>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WEB_STRINGHE");

                entity.Property(e => e.SAmbiente)
                    .HasColumnName("S_AMBIENTE")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SData)
                    .HasColumnName("S_DATA")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.SOra)
                    .HasColumnName("S_ORA")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SProgramma)
                    .HasColumnName("S_PROGRAMMA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SStringa)
                    .HasColumnName("S_STRINGA")
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .HasColumnName("TIMESTAMP")
                    .HasColumnType("DATE")
                    .HasDefaultValueSql(@"Sysdate
");
            });

            modelBuilder.HasSequence("CODICE_WEB_LOG");

            modelBuilder.HasSequence("IDDOMANDA");

            modelBuilder.HasSequence("IDINTERVISTA");

            modelBuilder.HasSequence("IDQUESTIONARIO");

            modelBuilder.HasSequence("IDREGOLA");

            modelBuilder.HasSequence("IDRISPOSTA");

            modelBuilder.HasSequence("IDSERVIZIO");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
