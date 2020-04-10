using Cloud.Ocr.Activities.Properties;
using Cloud.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities.Localization;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.IdCardActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.IdCardActivity_Description))]
    public class IdCardActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.IdCard;
        }
    }
}

