using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StructuredMinimalApi.Client.SDK;

namespace StructuredMinimalApi.IntegrationTests
{
    [TestClass]
    public class ProgramTest
    {

        public static StructuredMinimalApiClient Client { get; private set; }

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext _)
        {
            var application = new WebApplicationFactory<Program>();
               
            var client = application.CreateClient();

            Client = new StructuredMinimalApiClient(client);
        }
    }
}
