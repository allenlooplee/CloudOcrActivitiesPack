using Cloud.Ocr.Activities.Design.Designers;
using Cloud.Ocr.Activities.Design.Properties;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;
using System.ComponentModel.Design;

namespace Cloud.Ocr.Activities.Design
{
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            #region Setup

            var builder = new AttributeTableBuilder();
            builder.ValidateTable();

            var categoryAttribute = new CategoryAttribute($"{Resources.Category}");
            var recognizersCategoryAttribute = new CategoryAttribute($"{Resources.RecognizersCategory}");
            var clientsCategoryAttribute = new CategoryAttribute($"{Resources.ClientsCategory}");

            #endregion Setup


            builder.AddCustomAttributes(typeof(OcrScope), categoryAttribute);
            builder.AddCustomAttributes(typeof(OcrScope), new DesignerAttribute(typeof(OcrScopeDesigner)));
            builder.AddCustomAttributes(typeof(OcrScope), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(BankCardActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(BankCardActivity), new DesignerAttribute(typeof(BankCardActivityDesigner)));
            builder.AddCustomAttributes(typeof(BankCardActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(MockOcrClientActivity), clientsCategoryAttribute);
            builder.AddCustomAttributes(typeof(MockOcrClientActivity), new DesignerAttribute(typeof(MockOcrClientActivityDesigner)));
            builder.AddCustomAttributes(typeof(MockOcrClientActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(IdCardActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(IdCardActivity), new DesignerAttribute(typeof(IdCardActivityDesigner)));
            builder.AddCustomAttributes(typeof(IdCardActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), new DesignerAttribute(typeof(BusinessLicenseActivityDesigner)));
            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(VatInvoiceActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new DesignerAttribute(typeof(VatInvoiceActivityDesigner)));
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(TaxiReceiptActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(TaxiReceiptActivity), new DesignerAttribute(typeof(TaxiReceiptActivityDesigner)));
            builder.AddCustomAttributes(typeof(TaxiReceiptActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(TrainTicketActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(TrainTicketActivity), new DesignerAttribute(typeof(TrainTicketActivityDesigner)));
            builder.AddCustomAttributes(typeof(TrainTicketActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(QuotaInvoiceActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(QuotaInvoiceActivity), new DesignerAttribute(typeof(QuotaInvoiceActivityDesigner)));
            builder.AddCustomAttributes(typeof(QuotaInvoiceActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(HouseholdRegisterActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(HouseholdRegisterActivity), new DesignerAttribute(typeof(HouseholdRegisterActivityDesigner)));
            builder.AddCustomAttributes(typeof(HouseholdRegisterActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(BirthCertificateActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(BirthCertificateActivity), new DesignerAttribute(typeof(BirthCertificateActivityDesigner)));
            builder.AddCustomAttributes(typeof(BirthCertificateActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(PassportActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(PassportActivity), new DesignerAttribute(typeof(PassportActivityDesigner)));
            builder.AddCustomAttributes(typeof(PassportActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(HkMacauExitentrypermitActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(HkMacauExitentrypermitActivity), new DesignerAttribute(typeof(HkMacauExitentrypermitActivityDesigner)));
            builder.AddCustomAttributes(typeof(HkMacauExitentrypermitActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(TaiwanExitentrypermitActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(TaiwanExitentrypermitActivity), new DesignerAttribute(typeof(TaiwanExitentrypermitActivityDesigner)));
            builder.AddCustomAttributes(typeof(TaiwanExitentrypermitActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(DriverLicenseActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(DriverLicenseActivity), new DesignerAttribute(typeof(DriverLicenseActivityDesigner)));
            builder.AddCustomAttributes(typeof(DriverLicenseActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(VehicleLicenseActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(VehicleLicenseActivity), new DesignerAttribute(typeof(VehicleLicenseActivityDesigner)));
            builder.AddCustomAttributes(typeof(VehicleLicenseActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(VehicleInvoiceActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(VehicleInvoiceActivity), new DesignerAttribute(typeof(VehicleInvoiceActivityDesigner)));
            builder.AddCustomAttributes(typeof(VehicleInvoiceActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(VehicleCertificateActivity), recognizersCategoryAttribute);
            builder.AddCustomAttributes(typeof(VehicleCertificateActivity), new DesignerAttribute(typeof(VehicleCertificateActivityDesigner)));
            builder.AddCustomAttributes(typeof(VehicleCertificateActivity), new HelpKeywordAttribute(""));


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
