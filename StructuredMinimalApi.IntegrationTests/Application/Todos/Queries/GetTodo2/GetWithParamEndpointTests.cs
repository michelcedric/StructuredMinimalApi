using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace StructuredMinimalApi.IntegrationTests.Application.Todos.Queries.GetTodo2
{
    [TestClass]
    public class GetWithParamEndpointTests
    {
        [TestMethod]
        public async Task HandleValid()
        {
            var param = "Toto42";

            var response = await ProgramTest.Client.GetWithParamAsync(param);
            Assert.AreEqual($"Hello World! 2 {param}", response);
        }
    }
}
