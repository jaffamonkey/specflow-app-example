using NUnit.Framework;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using TechTalk.SpecFlow;

namespace testingbot_specflow
{
    [Binding]
    public class SingleStep
    {
        private AppiumDriver<AndroidElement> _driver;
        readonly TestingBotDriver _tbDriver;

        public SingleStep()
        {
            _tbDriver = (TestingBotDriver) ScenarioContext.Current["tbDriver"];
        }

        [Given(@"I am using the calculator")]
        public void GivenIAmOnTheGooglePage()
        {
            _driver = _tbDriver.Init();
            _driver.LaunchApp();
        }

        [When(@"I add inputA for ""(.*)""")]
        public void WhenIAddA(string amount)
        {
            AndroidElement inputA = _driver.FindElementById("inputA");
            inputA.SendKeys(amount);
        }

        [When(@"I add inputB for ""(.*)""")]
        public void WhenIAddB(string amount)
        {
            AndroidElement inputB = _driver.FindElementById("inputB");
            inputB.SendKeys(amount);
        }

        [Then(@"I should see the sum ""(.*)""")]
        public void ThenIShouldSeeTitle(string sum)
        {
            Assert.That(_driver.FindElementByXPath("//android.widget.EditText[@content-desc=\"sum\"]").Text, Is.EqualTo(sum));
        }
    }
}
