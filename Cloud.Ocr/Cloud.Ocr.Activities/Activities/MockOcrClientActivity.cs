using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Cloud.Ocr.Activities.Properties;
using Cloud.Ocr.Contracts;
using Cloud.Ocr.Models;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;
using UiPath.Shared.Activities.Utilities;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.MockOcrClientActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.MockOcrClientActivity_Description))]
    public class MockOcrClientActivity : BaseOcrClientActivity
    {
        protected override IOcrClient GetOcrClient(AsyncCodeActivityContext context)
        {
            return new MockOcrClient();
        }
    }
}

