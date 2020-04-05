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


            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
