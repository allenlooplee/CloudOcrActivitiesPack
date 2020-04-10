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

            #endregion Setup


            builder.AddCustomAttributes(typeof(OcrScope), categoryAttribute);
            builder.AddCustomAttributes(typeof(OcrScope), new DesignerAttribute(typeof(OcrScopeDesigner)));
            builder.AddCustomAttributes(typeof(OcrScope), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(BankCardActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(BankCardActivity), new DesignerAttribute(typeof(BankCardActivityDesigner)));
            builder.AddCustomAttributes(typeof(BankCardActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(MockOcrClientActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(MockOcrClientActivity), new DesignerAttribute(typeof(MockOcrClientActivityDesigner)));
            builder.AddCustomAttributes(typeof(MockOcrClientActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(IdCardActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(IdCardActivity), new DesignerAttribute(typeof(IdCardActivityDesigner)));
            builder.AddCustomAttributes(typeof(IdCardActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), new DesignerAttribute(typeof(BusinessLicenseActivityDesigner)));
            builder.AddCustomAttributes(typeof(BusinessLicenseActivity), new HelpKeywordAttribute(""));

            builder.AddCustomAttributes(typeof(VatInvoiceActivity), categoryAttribute);
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new DesignerAttribute(typeof(VatInvoiceActivityDesigner)));
            builder.AddCustomAttributes(typeof(VatInvoiceActivity), new HelpKeywordAttribute(""));

            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
