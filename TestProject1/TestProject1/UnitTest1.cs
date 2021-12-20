using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TestProject1
{


    public class UnitTest1
    {
        [Fact(Skip ="A reason")]
        public void Test1()
        {
            Assert.False(true, "This should fail");  
        }

        [Fact(Skip = "A reason")]
        public void Test2()
        {
            Assert.True(true, "This will pass");
        }

        [Theory]
        [InlineData("5")]
        [InlineData("7")]
        [InlineData("9")]
        public void TestDetails(string rowNum)
        {
            string URL = "https://localhost:44374/Bookandcosts";
            ChromeDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(URL);
            IWebElement bookTitle = driver.FindElement(By.XPath(string.Format("/html/body/div[1]/main/table/tbody/tr[{0}]/td[1]",rowNum)));
            string title = bookTitle.Text;

            IWebElement detailLink = driver.FindElement(By.XPath(string.Format("/html/body/div/main/table/tbody/tr[{0}]/td[4]/a[2]", rowNum)));
            detailLink.Click();
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            wait.Until(wt => wt.FindElement(By.XPath("/html/body/div/main/h1")));

            IWebElement detailTitle = driver.FindElement(By.XPath("/html/body/div/main/div[1]/dl/dd[1]"));
            Assert.Equal(title, detailTitle.Text);
            driver.Close();
        }
    }
}
