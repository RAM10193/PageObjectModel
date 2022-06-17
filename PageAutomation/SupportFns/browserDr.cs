using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageAutomation.SupportFns
{
    public class browserDr
    {
            IWebDriver dr;
            public IWebDriver getchromedriver(){
                dr = new ChromeDriver();
                dr.Manage().Window.Maximize();
                return dr;
            }      

    }
}
