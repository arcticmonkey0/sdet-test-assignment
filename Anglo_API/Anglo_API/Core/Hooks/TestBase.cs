using Anglo_API.Apis;
using System.Configuration;
using TechTalk.SpecFlow;

namespace Anglo_API.Core.Hooks
{
    [Binding]
    public class TestBase
    {
        internal readonly AngloApi AngloApi = new AngloApi(ConfigurationManager.AppSettings["BaseApiUrl"]);

        public TestBase(ScenarioContext scenarioContext)
        {
            Context = scenarioContext;
        }

        protected ScenarioContext Context { get; }

    }
}
