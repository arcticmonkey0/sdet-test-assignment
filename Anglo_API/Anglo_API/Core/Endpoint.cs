using System.Net;
using NUnit.Framework;
using RestSharp;

namespace Anglo_API.Core
{
    public class Endpoint
    {
        protected Endpoint(EndpointUrl endpointUrl)
        {
            EndpointUrl = endpointUrl;
        }

        protected EndpointUrl EndpointUrl { get; }
        
        protected T Get<T>(ContentFormat responseFormat = ContentFormat.Json, HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
        {
            RestResponse response = InitRestClient().Get(new RestRequest());
            Assert.AreEqual(expectedStatusCode, response.StatusCode, "Invalid status code!");
            return (T)new ContentConverter(responseFormat).ConvertStringToContent(response.Content, typeof(T));
        }

        private RestClient InitRestClient() => new RestClient(EndpointUrl.FullUrl);
    }
}
