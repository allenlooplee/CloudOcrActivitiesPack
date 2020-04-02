using Cloud.Ocr.Activities.Design.Properties;
using System.Activities.Presentation.Metadata;
using System.ComponentModel;

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



            MetadataStore.AddAttributeTable(builder.CreateTable());
        }
    }
}
