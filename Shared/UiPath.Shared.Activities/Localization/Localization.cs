using System;
using System.ComponentModel;
using UiPath.Shared.Localization;
using UiPath.Shared.Activities.Utilities;

namespace UiPath.Shared.Activities.Localization
{
    [AttributeUsage(AttributeTargets.Property)]
    public class LocalizedCategoryAttribute : CategoryAttribute
    {
        public LocalizedCategoryAttribute(string category) : this(category, null)
        {
        }

        public LocalizedCategoryAttribute(string resourceKey, Type resourceType) : base(resourceKey)
        {
            _category = resourceKey.GetLocalizedString(resourceType);
        }

        private string _category;
        protected override string GetLocalizedString(string value) => _category;
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Class)]
    public class LocalizedDisplayNameAttribute : DisplayNameAttribute
    {
        public LocalizedDisplayNameAttribute(string displayName) : this(displayName, null)
        {
        }

        public LocalizedDisplayNameAttribute(string resourceKey, Type resourceType) : base(resourceKey)
        {
            _displayName = resourceKey.GetLocalizedString(resourceType);
        }

        private string _displayName;
        public override string DisplayName => _displayName;
    }

    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        public LocalizedDescriptionAttribute(string displayName) : this(displayName, null)
        {
        }

        public LocalizedDescriptionAttribute(string resourceKey, Type resourceType) : base(resourceKey)
        {
            _description = resourceKey.GetLocalizedString(resourceType);
        }

        private string _description;
        public override string Description => _description;
    }
}
