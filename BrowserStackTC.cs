using System;
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace BrowserStackTest
{
  [TestFixture]
  public class Program 
    {
      public IWebDriver _driver;

  [SetUp]
    public void Init()
    {
      string USERNAME = "martindusek3";
      string AUTOMATE_KEY = "QYk6SqtzuJobfDxDrTj1";

      DesiredCapabilities caps = new DesiredCapabilities();

        caps.SetCapability("browserstack.local", "true");
        caps.SetCapability("acceptSslCerts", "true");
        caps.SetCapability("os", "Windows");
        caps.SetCapability("os_version", "10");
        caps.SetCapability("browser", "Edge");
        caps.SetCapability("browser_version", "latest");
        caps.SetCapability("resolution", "1680x1050");
        caps.SetCapability("browserstack.user", USERNAME);
        caps.SetCapability("browserstack.key", AUTOMATE_KEY);
        caps.SetCapability("name", "martindusek3's Windows Test");

        _driver = new RemoteWebDriver(new Uri("https://hub-cloud.browserstack.com/wd/hub/"), caps);
        }

    [Test]
        public void BrowserStackTest()
        {
            _driver.Navigate().GoToUrl("LINK-TO-A-WEBSITE");
        }

    [TearDown]
        public void Cleanup()
        {
            _driver.Quit();        
        }
    }
}
