using System.Linq;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;
using TechTalk.SpecFlow;

namespace TimeForCoffee.Tests.Feature.Steps
{
    [Binding]
    public class HttpBindings
    {
        private static HttpClient _client;

        [BeforeTestRun]
        public static void Initialize()
        {
            _client = new HttpClient();
        }

        [Given(@"I send a POST request to '(.*)' with the body")]
        public void GivenISendAPOSTRequestToWithTheBody(string uri, Table table)
        {
            var json = JsonConvert.SerializeObject(table.Rows.First());
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _ = _client.PostAsync(uri, content).Result;
        }
    }
}
