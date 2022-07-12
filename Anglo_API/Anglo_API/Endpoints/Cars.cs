using Anglo_API.Core;
using Anglo_API.Messages;
using System.Collections.Generic;
using System.Net;

namespace Anglo_API.Endpoints
{
    public class Cars : Endpoint
    {
        public Cars(string baseUrl) : base(new EndpointUrl(baseUrl, "cars/{0}"))
        {
        }

        public List<Car> GetCarByType(string type)
        {
            EndpointUrl.SetUrlVariables(type);
            return Get<List<Car>>();
        }

        public void GetCarByType(string type, HttpStatusCode statusCode)
        {
            EndpointUrl.SetUrlVariables(type);
            Get<object>(expectedStatusCode: statusCode);
        }
    }
}
