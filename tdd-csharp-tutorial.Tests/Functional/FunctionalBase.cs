using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using System.Diagnostics;
using System.IO;

namespace tdd_csharp_tutorial.Tests.Functional
{
    public class FunctionalBase
    {
        const int iisPort = 4321;
        private Process _iisProcess;

        public IWebDriver WebDriver { get; private set; }

        [TestInitialize]
        public void BaseTestInitialize()
        {
            StartIIS();
            WebDriver = new InternetExplorerDriver();
        }

        [TestCleanup]
        public void BaseTestCleanup()
        {
            WebDriver.Quit();
            WebDriver = null;
            if (_iisProcess.HasExited == false) {
                _iisProcess.Kill();
            }
        }
 
        private void StartIIS() {
            var applicationPath = GetApplicationPath("tdd-csharp-tutorial");
            var programFiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
 
            _iisProcess = new Process();
            _iisProcess.StartInfo.FileName = programFiles + "\\IIS Express\\iisexpress.exe";
            _iisProcess.StartInfo.Arguments = string.Format("/path:\"{0}\" /port:{1}", applicationPath, iisPort);
            _iisProcess.Start();
        }
 
        protected virtual string GetApplicationPath(string applicationName) {
            var solutionFolder = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)));
            return Path.Combine(solutionFolder, applicationName);
        }
 
        public string GetAbsoluteUrl(string relativeUrl) {
            if (!relativeUrl.StartsWith("/")) {
                relativeUrl = "/" + relativeUrl;
            }
            return String.Format("http://localhost:{0}{1}", iisPort, relativeUrl);
        }
    }
}