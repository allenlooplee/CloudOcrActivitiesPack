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
    public class MockOcrClientActivity : ContinuableAsyncCodeActivity
    {
        #region Properties

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        #endregion


        #region Constructors

        public MockOcrClientActivity()
        {
        }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(CodeActivityMetadata metadata)
        {

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<AsyncCodeActivityContext>> ExecuteAsync(AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            // Inputs
            IOcrClient ocrClient = new MockOcrClient();
            var objectContainer = context.GetFromContext<IObjectContainer>(OcrScope.ParentContainerPropertyTag);
            objectContainer.Add(ocrClient);

            ///////////////////////////
            // Add execution logic HERE
            ///////////////////////////

            // Outputs
            return (ctx) => { };
        }

        #endregion
    }
}

