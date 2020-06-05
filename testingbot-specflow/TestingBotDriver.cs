using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using TechTalk.SpecFlow;

namespace testingbot_specflow
{
    [Binding]
    public sealed class testingbot_specflow
    {
        private TestingBotDriver tbDriver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            tbDriver = new TestingBotDriver(ScenarioContext.Current);
            ScenarioContext.Current["tbDriver"] = tbDriver;
        }

        [AfterScenario]
        public void AfterScenario()
        {
            tbDriver.Cleanup();
        }
    }

    public class TestingBotDriver
    {
        private AppiumDriver<AndroidElement> driver;
        private ScenarioContext current;

        public TestingBotDriver(ScenarioContext current)
        {
            this.current = current;
        }

        public AppiumDriver<AndroidElement> Init()
        {
            AppiumOptions appiumOptions = new AppiumOptions();
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, "Galaxy S9");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Android");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformVersion, "9.0");
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, "https://testingbot.com/appium/sample.apk");

            String key = Environment.GetEnvironmentVariable("TB_KEY");
            String secret = Environment.GetEnvironmentVariable("TB_SECRET");

            appiumOptions.AddAdditionalCapability("key", key);
            appiumOptions.AddAdditionalCapability("secret", secret);

            AppiumDriver<AndroidElement> driver = new AndroidDriver<AndroidElement>(
                new Uri("https://hub.testingbot.com/wd/hub"),
                appiumOptions
            );
            return driver;
        }

        public void Cleanup()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
