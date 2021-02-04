using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Mintos.Tests
{
	[TestFixture]
	internal class TestBase
	{
		internal struct TestSettings
		{
			internal string Browser, BaseURL, User, Password;
		}
		protected IWebDriver DRIVER = null;
		protected TestSettings Settings;

		[SetUp]
		public void SetUp()
		{
			DRIVER?.Quit();

			if (TestContext.Parameters.Exists("URL"))
			{
				Settings.BaseURL = TestContext.Parameters.Get("URL");
			}

			if (TestContext.Parameters.Exists("USER_ID"))
			{
				Settings.User = TestContext.Parameters.Get("USER_ID");
			}
			if (TestContext.Parameters.Exists("PASSWORD"))
			{
				Settings.Password = TestContext.Parameters.Get("PASSWORD");
			}

			if (TestContext.Parameters.Exists("BROWSER"))
			{
				Settings.Browser = TestContext.Parameters.Get("BROWSER");
			}


			switch (Settings.Browser)
			{
				case "chrome":
					var chromeoptions = new ChromeOptions();
					DRIVER = new ChromeDriver(Path.GetDirectoryName(typeof(TestBase).Assembly.Location), chromeoptions, Configuration.DefaultDriverTimeout);
					break;
				case "firefox":
					var firefoxoptions = new FirefoxOptions();
					DRIVER = new FirefoxDriver(Path.GetDirectoryName(typeof(TestBase).Assembly.Location), firefoxoptions);
					break;
				case "ie":
					var ieoptions = new InternetExplorerOptions();
					ieoptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
					ieoptions.IgnoreZoomLevel = true;
					DRIVER = new InternetExplorerDriver(Path.GetDirectoryName(typeof(TestBase).Assembly.Location), ieoptions, Configuration.DefaultDriverTimeout);
					break;
				case "edge":
					var edgeoptions = new EdgeOptions();
					edgeoptions.PageLoadStrategy = PageLoadStrategy.Eager;
					DRIVER = new EdgeDriver(Path.GetDirectoryName(typeof(TestBase).Assembly.Location), edgeoptions);
					break;
			}

			DRIVER.Manage().Window.Maximize();
			DRIVER.Manage().Timeouts().PageLoad = Configuration.DefaultDriverTimeout;
			DRIVER.Manage().Timeouts().ImplicitWait = Configuration.DefaultElementStatusCheckTimeout;
		}

		[TearDown]
		public void TearDown()
		{
			try
			{
				if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
				{
                    var screenshot = ((ITakesScreenshot)DRIVER).GetScreenshot();
					var testname = TestContext.CurrentContext.WorkDirectory + TestContext.CurrentContext.Test.FullName + DateTime.Now.Ticks.ToString() + ".PNG";
                    screenshot.SaveAsFile(testname, ScreenshotImageFormat.Png);
                }
			}
			catch (UnhandledAlertException)
			{
				DRIVER.SwitchTo().Alert().Accept();
			}
			DRIVER?.Quit();
		}

	}
}
