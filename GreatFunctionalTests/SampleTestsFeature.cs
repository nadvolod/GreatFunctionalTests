using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace GreatFunctionalTests
{
    [TestFixture]
    [Category("SmokeTest")]
    public class SampleTestsFeature
    {
        [Test]
        [Author("NikolayAdvolodkin")]
        [Description("Validating that sprint 1 form can be filled out")]
        [Property("TCID","1")]
        public void TCID1()
        {
            //Sprint1Page sprintOnePage = new Sprint1Page(Driver);
            //sprintOnePage.GoTo();
            //sprintOnePage.FillOutAndSubmitForm();

            //UltimateQAHomePage ultimateQAHomePage = new UltimateQAHomePage(Driver);
            //Assert.That(ultimateQAHomePage.IsOpen, Is.True);
        }
    }
}
