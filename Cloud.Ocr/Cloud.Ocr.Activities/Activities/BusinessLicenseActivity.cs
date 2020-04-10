using Cloud.Ocr.Activities.Properties;
using Cloud.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities.Localization;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.BusinessLicenseActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.BusinessLicenseActivity_Description))]
    public class BusinessLicenseActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.BusinessLicense;
        }
    }
}

