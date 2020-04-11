using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using System.Activities.Statements;
using System.ComponentModel;
using Cloud.Ocr.Activities.Properties;
using UiPath.Shared.Activities;
using UiPath.Shared.Activities.Localization;
using Cloud.Ocr.Contracts;
using Cloud.Ocr.Models;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.OcrScope_DisplayName))]
    [LocalizedDescription(nameof(Resources.OcrScope_Description))]
    public class OcrScope : ContinuableAsyncNativeActivity
    {
        #region Properties

        [Browsable(false)]
        public Activity Head { get; set; }

        [Browsable(false)]
        public Activity Body { get; set; }

        /// <summary>
        /// If set, continue executing the remaining activities even if the current activity has failed.
        /// </summary>
        [LocalizedCategory(nameof(Resources.Common_Category))]
        [LocalizedDisplayName(nameof(Resources.ContinueOnError_DisplayName))]
        [LocalizedDescription(nameof(Resources.ContinueOnError_Description))]
        public override InArgument<bool> ContinueOnError { get; set; }

        // A tag used to identify the scope in the activity context
        internal static string ParentContainerPropertyTag => "OcrScope";

        // Object Container: Add strongly-typed objects here and they will be available in the scope's child activities.
        private readonly IObjectContainer _objectContainer;

        #endregion


        #region Constructors

        public OcrScope(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;

            Body = new Sequence { DisplayName = Resources.Do };
        }

        public OcrScope() : this(new ObjectContainer())
        {

        }

        #endregion


        #region Protected Methods

        protected override void CacheMetadata(NativeActivityMetadata metadata)
        {

            base.CacheMetadata(metadata);
        }

        protected override async Task<Action<NativeActivityContext>> ExecuteAsync(NativeActivityContext context, CancellationToken cancellationToken)
        {
            return (ctx) => {
                // Schedule child activities
                if (Head != null && Body != null)
                {
                    var children = new ActivityAction<IObjectContainer>
                    {
                        Argument = new DelegateInArgument<IObjectContainer>(ParentContainerPropertyTag),
                        Handler = new Sequence
                        {
                            Activities = { Head, Body }
                        }
                    };

                    ctx.ScheduleAction<IObjectContainer>(children, _objectContainer, OnCompleted, OnFaulted);
                }
            };
        }

        #endregion


        #region Events

        private void OnFaulted(NativeActivityFaultContext faultContext, Exception propagatedException, ActivityInstance propagatedFrom)
        {
            faultContext.CancelChildren();
            Cleanup();
        }

        private void OnCompleted(NativeActivityContext context, ActivityInstance completedInstance)
        {
            Cleanup();
        }

        #endregion


        #region Helpers
        
        private void Cleanup()
        {
            var disposableObjects = _objectContainer.Where(o => o is IDisposable);
            foreach (var obj in disposableObjects)
            {
                if (obj is IDisposable dispObject)
                    dispObject.Dispose();
            }
            _objectContainer.Clear();
        }

        #endregion
    }
}

