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
        [LocalizedDisplayName(nameof(Resources.MockOcrClientActivity_Content_DisplayName))]
        [LocalizedDescription(nameof(Resources.MockOcrClientActivity_Content_Description))]
        [LocalizedCategory(nameof(Resources.Input_Category))]
        public InArgument<string> Content { get; set; }

        protected override IOcrClient GetOcrClient(AsyncCodeActivityContext context)
        {
            var content = Content.Get(context);
            return new MockOcrClient(content);
        }
    }
}

