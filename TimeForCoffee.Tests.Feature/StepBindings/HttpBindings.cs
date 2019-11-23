using TechTalk.SpecFlow;

namespace TimeForCoffee.Tests.Feature.StepBindings
{
    [Binding]
    public class HttpBindings
    {
        [Given(@"I send a POST request to '(.*)' with the body")]
        public void GivenISendAPOSTRequestToWithTheBody(string url, Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
