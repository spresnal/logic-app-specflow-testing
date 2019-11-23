using System;

namespace TimeForCoffee.Tests.Feature
{
    public static class EnvVariables
    {
        public static string AzureClientId = Environment.GetEnvironmentVariable("AzureClientId");
        public static string AzureClientSecret = Environment.GetEnvironmentVariable("AzureClientSecret");
        public static string AzureTenantId = Environment.GetEnvironmentVariable("AzureTenantId");
        public static string SubscriptionId = Environment.GetEnvironmentVariable("SubscriptionId");
        public static string ResourceGroup = Environment.GetEnvironmentVariable("ResourceGroup");
    }
}
