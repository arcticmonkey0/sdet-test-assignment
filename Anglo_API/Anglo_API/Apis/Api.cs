using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Anglo_API.Core;

namespace Anglo_API.Apis
{
    internal class Api
    {
        protected string BaseUrl;

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