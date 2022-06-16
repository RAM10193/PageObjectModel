using NUnit.Framework;
using PageAutomation.SupportFns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageAutomation
{
    class Program
    {
      [SetUp]
      public void initialize()
        {
            driverInit.driver.Navigate().GoToUrl("https://www.orangehrm.com/open-source/open-source-on-demand");
            driverInit.driver.Manage().Window.Maximize();
        }

    [Test]
    public void Loginfunction()
        {

        }

    [TearDown]
    public void closebrowser()
        {

        }   
    }
}
