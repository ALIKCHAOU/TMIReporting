using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMIReporting.Model
{
   public class OrderTransferEtranger
    {
        public String ReferenceClient { get; set; }
        public String ReferenceAgence { get; set; }
        public String ReferenceSBE { get; set; }
        public String CodeBanque { get; set; }
        public String CodeGuichet { get; set; }
        public String NumeroCompte { get; set; }
        public String CleRIB { get; set; }
        public String CodeDevise { get; set; }
        public String Nom { get; set; }
        public String Adresse { get; set; }
        public String Email { get; set; }
        public String ModeReglement { get; set; }
        public String ModeTransfert { get; set; }
        public String Montant { get; set; }
        public String ReparationFrais { get; set; }
        public String MotifPaiement { get; set; }
        public String NomBeneficiaire { get; set; }
        public String AdresseBenificiaire { get; set; }
        public String CodePostalBeneficiaire { get; set; }
        public String VilleBeneficiaire { get; set; }
        public String PaysBinificiaire { get; set; }
        public String NumeroCompteBeneficiaire { get; set; }
        public String NomBanqueBeneficiaire { get; set; }
        public String VilleBanqueBeneficiaire { get; set; }
        public String PaysBanqueBeneficiaire { get; set; }
        public String AdresseSWIFTBanque { get; set; }
        public String LibelleDossierRegle { get; set; }
        public String CodeDossierRegle { get; set; }
        public String NumeroDossierRegle { get; set; }
        public String DateDossierRegle { get; set; }
    }
}
