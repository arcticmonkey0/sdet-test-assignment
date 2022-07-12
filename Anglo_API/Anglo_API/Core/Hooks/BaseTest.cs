using Anglo_API.Apis;
using NUnit.Framework;
using System.Configuration;

namespace Anglo_API.Core.Hooks
{
    [TestFixture]
    public class BaseTest
    {
        internal readonly AngloApi AngloApi = new AngloApi(ConfigurationManager.AppSettings["BaseApiUrl"]);
    }
}
