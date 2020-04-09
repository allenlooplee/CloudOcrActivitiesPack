using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using UiPath.Shared.Localization;

namespace UiPath.Shared.Activities.Utilities
{
    static class ResourceExtensions
    {
        public static string GetLocalizedString(this string resourceKey, Type resourceType = null)
        {
            string localizedString;

            if (resourceType != null)
            {
                var propertyInfo = resourceType.GetProperty(resourceKey, BindingFlags.Public | BindingFlags.Static);
                localizedString = propertyInfo.GetValue(null) as string;
            }
            else
            {
                localizedString = SharedResources.ResourceManager.GetString(resourceKey);
            }

            return localizedString ?? resourceKey;
        }
    }
}
