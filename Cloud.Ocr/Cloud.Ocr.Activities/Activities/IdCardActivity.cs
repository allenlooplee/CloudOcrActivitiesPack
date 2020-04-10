using Cloud.Ocr.Activities.Properties;
using Cloud.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities.Localization;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.IdCardActivity_DisplayName), typeof(Resources))]
    [LocalizedDescription(nameof(Resources.IdCardActivity_Description), typeof(Resources))]
    public class IdCardActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.IdCard;
        }
    }
}

