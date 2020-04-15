using Cloud.Ocr.Activities.Properties;
using Cloud.Ocr.Models;
using Cloud.Ocr.Contracts;
using UiPath.Shared.Activities.Localization;
using System.Activities;
using System.Collections.Generic;

namespace Cloud.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.IdCardActivity_DisplayName))]
    [LocalizedDescription(nameof(Resources.IdCardActivity_Description))]
    public class IdCardActivity : BaseOcrActivity
    {
        [LocalizedCategory(nameof(Resources.Input_Category))]
        [LocalizedDisplayName(nameof(Resources.IdCardActivity_CardSide_DisplayName))]
        [LocalizedDescription(nameof(Resources.IdCardActivity_CardSide_Description))]
        public InArgument<CardSide> CardSide { get; set; }

        protected override Dictionary<string, object> GetRecognizerOptions(AsyncCodeActivityContext context)
        {
            var cardSide = CardSide.Get(context);

            return new Dictionary<string, object>
            {
                [nameof(CardSide)] = cardSide
            };
        }

        protected override string GetRecognizerName()
        {
            return RecognizerNames.IdCard;
        }
    }

    public enum CardSide
    {
        Front,
        Back
    }
}

