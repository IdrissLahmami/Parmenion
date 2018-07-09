using System.Threading;
using TechTalk.SpecFlow;

namespace UI.Automation
{
    [Binding]
    public class TestFeatureSteps
    {
        [Given(@"I try to get framework going")]
        public void GivenITryToGetFrameworkGoing()
        {
            Thread.Sleep(100);
        }
        
        [Then(@"It should work")]
        public void ThenItShouldWork()
        {
            Thread.Sleep(100);
        }
    }
}
