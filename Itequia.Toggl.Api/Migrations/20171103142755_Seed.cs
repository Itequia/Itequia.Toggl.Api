using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Itequia.Toggl.Api.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('adria.alvarez@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('adrian.cano@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('alejandro.delamo@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('blai.samitier@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('daniel.coll@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('david.canut@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('gaston.zitelli@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('jose.vioque@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('lucica.ibanescu@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('mcarme.capdevila@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('mario.mir@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('marlon.castillo@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('marta.garcia@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('miquel.marin@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('miquel.molla@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('nicolas.scandalis@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('omar.ghadban@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('oriol.quinquilla@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('pau.morato@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('pere.berge@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('ricard.cepero@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('sergi.forns@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('sergi.perucho@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('sergio.andres@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('susana.castela@itequia.com')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Users] VALUES ('teresa.sujar@itequia.com')");

            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('14.Cetaqua.Hosting')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('14.EBMT.SupportContract2015')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('14.Ideria.Support365')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.TRAM.SupportGestorDenuncies')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.HCBCN.StandardSupport')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.HCBCN.UrgentSupport')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.AMB.HostingCarboWeb')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.Adam.CustomerSupport')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.Idilia.CustomerSupport')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.Cetaqua.Observatorio')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.Cetaqua.Aquaenvec.Ampliacio')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.HCBCN.formacio')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.Celsa.Support')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.Euroleague.SupportLive')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('15.Itequia.PICA')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Dialoga.Retribucion902')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Nexica.SinergiaSocial')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Tekmanbooks.Hosting')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.AMB.HostingCarboWeb')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Proclinic.CustomerCare')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.TRAM.AmpliacioGestorDenuncies.LOPD')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Cetaqua.HostingCarboweb')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Cetaqua.HostingABCarboweb')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.BSM.AppSantJordi')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Acciona.AppACTOR')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.UIBS.StudentPortal.Stage2')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Tekmanbooks.Hosting.AmpliacioBD')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.TRAM.app.NotificationHub')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.COMB.CustomerCare')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.LaSirena.CustomerCare')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Nae.CustomerCare')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.TRAM.OpenData')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.SDHumanCapital.Coworking')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Acciona.SendaNearSiteApp')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.TRAM.TramApp.Ecocalculadora')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Euroleague.LiveStats.ActualitzacioAPI')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Euroleague.LiveStats.CreacioNouServeiAPI')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.Tekmanbooks.HostingS3ProdDemo')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.TRAM.HostingS1OpenData')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.TRAM.TramApp.Fase2')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.CELSA.PowerpricingWeb.ModificacionsOctNov')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.AdvancedMusic.BBDDunicaSonar')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.CELSA.WebHOForge.Stage1')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('16.TRAM.OpenData.GTFS')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.LinkiaFP.EscuelasUCOC.HostingHibridS1S3')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TRAM.NovaWeb')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingWeb.ModificacionsDesembre16')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.EnquestesSatisfaccio')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Lavola.CustomerCareService')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.CustomerPortal.AmpliacióExtendedTeamFase3')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingWeb.France')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingWeb.ReportUK')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingWeb.PerformanceUnitTesting')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.COMB.AppMobil.NovesFuncionalitatsSDKCreacioApp')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Itequia.Hosting')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Audatex.ExtendedTeam')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeamSEO')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Acciona.SistemaMARES')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.LyraliaTrade.ExtendedTeam')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeamConshipping')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TekmanBooks.ExtendedTeam')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingWeb.CSSUK')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.LinkiaFP.ExtendedTeam.ExamViewer')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TekmanBooks.ExtendedTeam.ContenidosTelefonica')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TekmanBooks.ludilletres.metodesUserAPI')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Nae.ExtendedTeam.Holos')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.Powerpricing.Ireland')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Compettia.FormacioXamarin')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Acciona.Traspas')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TRAM.ExtendedTeam.Intranet')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Euroleague.LiveStats.BossaHores')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Euroleague.LiveStats.ActualitzacioAPI')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeam.SharePoint')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Volotea.FirebaseMarketingCloud')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingWeb.TYCSA')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeamMaquetacio')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Volotea.InvoiceAPI')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.Powerpricing.CSSUK.Annex1')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.Powerpricing.France.Annex1')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Volotea.FlightStatusAPI')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Volotea.FlightEvents')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Nae.ExtendedTeam.Holos.Anexo2')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Servis.ExtendedTeam')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Servis.ExtendedTeam.GestionFerias')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Nae.ExtendedTeam.Holos.Anexo1')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeam.SharePoint.Annex1')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeamConshipping.Annex1')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeamConshipping.Annex2')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TekmanBooks.ExtendedTeam.Annex3')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TekmanBooks.ExtendedTeam.Annex4')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeamConshipping.Annex3')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Cetaqua.Carboweb.Ampliacio3')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.CustomerPortal.ExtendedTeamAnnex3')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TekmanBooks.ExtendedTeam.ONMAT.DemoRegistre')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.LaSirena.RenovacioLlicenciesNintex')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingWeb.CSSUK.Annex2')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.FioriSBU')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingUK.WEXA')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.PowerpricingWeb.NotificacionCotizacion')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.CELSA.ExtendedTeam.SharePoint.Annex2')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Ideria.LlicenciesCSP')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.TekmanBooks.LlicenciesCSP')");
            migrationBuilder.Sql("INSERT INTO [dbo].[Projects]([Name]) VALUES ('17.Volotea.XamarinPX451')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
