using Cloud.Ocr.Activities.Properties;
using Cloud.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities.Localization;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.VatInvoiceActivity_DisplayName), typeof(Resources))]
    [LocalizedDescription(nameof(Resources.VatInvoiceActivity_Description), typeof(Resources))]
    public class VatInvoiceActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.VatInvoice;
        }
    }
}

