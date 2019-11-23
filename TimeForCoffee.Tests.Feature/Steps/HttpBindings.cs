using System.Collections.Generic;
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
        private static readonly Dictionary<string, string> HttpTriggerUris = new Dictionary<string, string>()
        {
            { "TimeForCoffee", "https://prod-78.eastus.logic.azure.com:443/workflows/336e6cfc4b1c4006ab19fe38402e62ee/triggers/manual/paths/invoke?api-version=2016-10-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=hwtWJD-ccugxtRd7FeeYjEcdm8rSmSAvzfLkYgMHBd8" }
        };

        [BeforeTestRun]
        public static void Initialize()
        {
            _client = new HttpClient();
        }

        [Given(@"I send a POST request to '(.*)' with the body")]
        public void GivenISendAPOSTRequestToWithTheBody(string uriKey, Table table)
        {
            var json = JsonConvert.SerializeObject(table.Rows.First());
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            _ = _client.PostAsync(HttpTriggerUris[uriKey], content).Result;
        }
    }
}
