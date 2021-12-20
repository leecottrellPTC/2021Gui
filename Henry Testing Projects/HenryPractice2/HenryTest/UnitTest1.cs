using Microsoft.AspNetCore.Mvc.Testing;
using Moq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;




namespace HenryTest
{
    public class UnitTest1 : IClassFixture<WebApplicationFactory<HenryPractice2.Startup>>
    {
        private readonly WebApplicationFactory<HenryPractice2.Startup> theFactory;
        private readonly HttpClient httpClient;
        public UnitTest1(WebApplicationFactory<HenryPractice2.Startup> factory)
        {
            theFactory = factory;
            httpClient = theFactory.CreateClient();
        }
        [Fact (Skip="Have a reason here")]
        public async void TestBookAndCostIndexLoads()
        {
            //Arrange
            var client = theFactory.CreateClient();
            //Act
            var response = await client.GetAsync("/BookAndCosts/Index");
            //Assert
            int code = (int) response.StatusCode;
            Assert.Equal(200, code);
        }//end of BookAndCostLoads test

  

        [Theory(Skip="Learning")]
        [InlineData("/")]
        [InlineData("/Home/Index")]
        [InlineData("/Home/Privacy")]
        [InlineData("/Home/Contact")]
        [InlineData("/Bookandcosts/Index")]
        public async Task TestAllPages(string url)
        {
            //Arrange
            var client = theFactory.CreateClient();
            //act
            var response = await client.GetAsync(url);
            //Assert
            int code = (int)response.StatusCode;
            Assert.Equal(200, code);
        }

        [Theory(Skip ="bored")]
        [InlineData("Jazz")]
        [InlineData("Harry Potter")]
        [InlineData("Jaws")]
        [InlineData("Band of Brothers")]
        public async Task TestForBooks(string title)
        {
            //Arrange
            //Act
            var response = await httpClient.GetAsync("/BookAndCosts/Index");
            var pageContent = await response.Content.ReadAsStringAsync();
            var contentString = pageContent.ToString();
            //Assert
            Assert.Contains(title, contentString);

        }
       
        
    }
}
