using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Cloud.Ocr.Activities.Properties;
using Cloud.Ocr.Contracts;
using Cloud.Ocr.Models;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.HouseholdRegisterActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.HouseholdRegisterActivity_Description))]
    public class HouseholdRegisterActivity : BaseOcrActivity
    {
        protected override string GetRecognizerName()
        {
            return RecognizerNames.HouseholdRegister;
        }
    }
}

