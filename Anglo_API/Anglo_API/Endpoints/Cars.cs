using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Anglo_API.Core;
using Anglo_API.Messages;
using RestSharp;

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
    }
}
