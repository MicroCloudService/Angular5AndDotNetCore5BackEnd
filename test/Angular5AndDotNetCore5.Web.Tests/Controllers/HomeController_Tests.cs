using System.Threading.Tasks;
using Angular5AndDotNetCore5.Models.TokenAuth;
using Angular5AndDotNetCore5.Web.Controllers;
using Shouldly;
using Xunit;

namespace Angular5AndDotNetCore5.Web.Tests.Controllers
{
    public class HomeController_Tests: Angular5AndDotNetCore5WebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}