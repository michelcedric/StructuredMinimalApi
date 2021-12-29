using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace StructuredMinimalApi.IntegrationTests.Application.Todos.Queries.GetTodos
{
    [TestClass]
    public class GetAllEndpointTests
    {
        [TestMethod]
        public async Task HandleValid()
        {
            var response = await ProgramTest.Client.GetAllAsync();
            Assert.AreEqual("Hello World!", response);
        }
    }
}
