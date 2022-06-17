using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using PageAutomation.PageFns;
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

    IWebDriver dr;

    static public void Main(String[] args)
    {

        Console.WriteLine("Test Initiated");
    }

     [SetUp]
      public void initialize()
        {
            //( Username : Admin | Password : admin123 )
            browserDr ts = new browserDr();
            dr = ts.getchromedriver();
            dr.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

    [Test]
    public void Loginfunction()
        {
            Login lgn = new Login(dr);
            lgn.orangelogin();
            AdminPg usrmgmt = new AdminPg(dr);
            usrmgmt.orangeAdminLinkClick();
            usrmgmt.orangeAdminUserMgmt();
        }

    [TearDown]
    public void closebrowser()
        {
            dr.Quit();
        }   
    }
}
