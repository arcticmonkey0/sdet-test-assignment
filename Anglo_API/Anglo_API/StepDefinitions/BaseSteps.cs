using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anglo_API.Core.Hooks;
using TechTalk.SpecFlow;

namespace Anglo_API.StepDefinitions
{
    [Binding]
    internal class BaseSteps : TestBase
    {
        public BaseSteps(ScenarioContext scenarioContext) : base(scenarioContext)
        {
        }

        [Given(@"I login as (.*)")]
        public void LoginAs(string userName)
        {
            // just a dummy step to have at least one Given statement at the beginning of the test
        }
    }
}
