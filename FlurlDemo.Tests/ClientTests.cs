using Flurl.Http.Testing;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace FlurlDemo.Tests
{
    [TestFixture]
    public class ClientTests
    {
        [Test]
        public async Task GetDataUsingFlurlSampleRequestsCallsApi()
        {
            var sut = new Client();
            
            using (var httpTest = new HttpTest())
            {
                // arrange
                httpTest.RespondWith("{\"id\":17408942,\"title\":\"What I Learned Making My Own JIT Language\", \"url\":\"http://www.mikedrivendevelopment.com/2018/06/what-i-learned-making-my-own-jit.html\"}");

                // act
                await sut.GetDataUsingFlurl<HackerNewsEntity>("http://anyaddress");

                // assert
                httpTest.ShouldHaveCalled("http://anyaddress").WithVerb(HttpMethod.Get);
            }
        }
    }
}
