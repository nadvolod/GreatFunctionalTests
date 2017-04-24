using NUnit.Framework;
using OpenQA.Selenium;
using Assert = NUnit.Framework.Assert;

namespace GreatFunctionalTests
{
    [TestFixture]
    [Category("SmokeTest")]
    public class SampleTestsFeature2
    {
        [Test]
        [Author("NikolayAdvolodkin")]
        [Description("Validating that sprint 1 form can be filled out")]
        [Property("TCID","2")]
        public void TCID2()
        {
            ////Sprint1Page sprintOnePage = new Sprint1Page(Driver);
            //sprintOnePage.GoTo();
            //Assert.That(sprintOnePage.IsOpen, Is.True);
            //sprintOnePage.FillOutAndSubmitForm();

            ////UltimateQAHomePage ultimateQAHomePage = new UltimateQAHomePage(Driver);
            //Assert.That(ultimateQAHomePage.IsOpen, Is.True);
        }
    }

    public class Sprint1Page
    {
        private IWebDriver Driver { get; set; }
        public Sprint1Page(IWebDriver driver )
        {
            Driver = driver;
        }

        public void GoTo()
        {
            Driver.Navigate().GoToUrl("https://www.ultimateqa.com/sample-application-lifecycle-sprint-1/");
        }

        public bool IsOpen =>
            Driver.Url.Equals("https://www.ultimateqa.com/sample-application-lifecycle-sprint-1/");

        public void FillOutAndSubmitForm()
        {
            Driver.FindElement(By.ClassName("firstname")).SendKeys("testUser");
            Driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }

        
    }
}
