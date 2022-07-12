using Anglo_API.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Anglo_API.Apis
{
    internal class Api
    {
        private string BaseUrl;

        internal Api(string baseUrl)
        {
            BaseUrl = baseUrl;
            GetEndpointProperties().ForEach(propertyInfo => propertyInfo.SetValue(
                this, Activator.CreateInstance(propertyInfo.PropertyType, BaseUrl)));
        }

        private List<PropertyInfo> GetEndpointProperties() => GetType().GetProperties().Where(propertyInfo
                => propertyInfo.PropertyType.IsSubclassOf(typeof(Endpoint)))
            .ToList();
    }
}