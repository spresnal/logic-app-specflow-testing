using System.Collections.Generic;
using System.Linq;
using Microsoft.Azure.Management.Logic;
using Microsoft.Azure.Management.ResourceManager.Fluent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using TimeForCoffee.Tests.Feature.Models;
using TimeForCoffee.Tests.Feature.Utilities;

namespace TimeForCoffee.Tests.Feature.Steps
{
    [Binding]
    public class LogicAppBindings
    {
        private static LogicAppExecutionRetriever _retriever;

        [BeforeTestRun]
        public static void Initialize()
        {
            var credentials = SdkContext.AzureCredentialsFactory
                .FromServicePrincipal(EnvVariables.AzureClientId,
                    EnvVariables.AzureClientSecret,
                    EnvVariables.AzureTenantId,
                    AzureEnvironment.AzureGlobalCloud);
            _retriever = new LogicAppExecutionRetriever(new LogicManagementClient(credentials)
            {
                SubscriptionId = EnvVariables.SubscriptionId
            }, EnvVariables.ResourceGroup);
        }

        [Then(@"I can verify the following logic app events for '(.*)'")]
        public void ThenICanVerifyTheFollowingLogicAppEventsFor(string logicApp, IList<LogicAppEvent> expectedEvents)
        {
            var actualEvents = _retriever.GetLatestExecutionEvents(logicApp);
            for (var i = 0; i < expectedEvents.Count; i++)
            {
                var expectedEvent = expectedEvents.ElementAt(i);
                LogicAppEvent actualEvent = null;
                try
                {
                    actualEvent = actualEvents.ElementAt(i);
                }
                catch
                {
                    Assert.Fail($"Expected {expectedEvent}, but there were no more events...");
                }
                Assert.AreEqual(expectedEvent.ToString(), actualEvent.ToString());
            }
        }
    }
}