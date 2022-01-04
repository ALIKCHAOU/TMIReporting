using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMIReporting.Model
{
   public class OrdreTransfertEtrangerOperationCommerciale
    {
        public String Numero { get; set; }
        public String ReglementRemiseDoc { get; set; }
        public String ReglementRemiseEffet { get; set; }
        public String ReglementFacture { get; set; }
        public String ReglementAvance { get; set; }
        public String NumeroCompteDebiter { get; set; }
        public String CodeDevise { get; set; }
        public String NomDonneurOrdre { get; set; }
        public String CodeDouane { get; set; }
        public String RegistreCommerce { get; set; }
        public String AdresseDonneurOrdre { get; set; }
        public String NomBanqueBeneficiaire { get; set; }
        public String VilleBanque { get; set; }
        public String PaysBanque { get; set; }
        public String SWIFTBanque { get; set; }
        public String TitulaireCompte { get; set; }
        public String MotifPaiement { get; set; }
        public String FraisCommissionsBIATCharge { get; set; }
        public String FraisCorrespondantCharge { get; set; }
        public String CodeTitreCommerceExterieur { get; set; }
        public String NumeroTitreCommerceExterieur { get; set; }
        public String DateTitreCommerceExterieur { get; set; }
        public String TypeVirment { get; set; }
    }
}
