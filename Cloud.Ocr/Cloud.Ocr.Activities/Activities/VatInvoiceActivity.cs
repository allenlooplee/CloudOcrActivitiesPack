using Cloud.Ocr.Activities.Properties;
using Cloud.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities.Localization;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.VatInvoiceActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.VatInvoiceActivity_Description))]
    public class VatInvoiceActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.VatInvoice;
        }
    }
}

