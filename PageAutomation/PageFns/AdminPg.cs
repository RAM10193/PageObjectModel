using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageAutomation.PageFns
{
    class AdminPg
    {
        static IWebDriver dr;
        private static By ADMINLINK = By.XPath("//a[contains(@href,'Admin')]");
        private static By USERMGMTOPTION = By.XPath("//a[contains(.,'User Management')]");
        private static By USERMGMTVIEWUSERS = By.XPath("//a[contains(.,'User Management')]//following::a[contains(@id,'menu_admin_viewSystemUsers')]");
        private static By USERMGMTADDBUTTON = By.XPath("//input[@id='btnAdd']");

        public AdminPg(IWebDriver driver)
        {
            dr = driver;
        }

        public void orangeAdminLinkClick()
        {
            if (dr.FindElement(ADMINLINK).Displayed)
            {
                dr.FindElement(ADMINLINK).Click();
            }
        }

        public void orangeAdminUserMgmt()
        {
            if (dr.FindElement(ADMINLINK).Displayed)
            {
                dr.FindElement(ADMINLINK).Click();
                dr.FindElement(USERMGMTOPTION).Click();
                dr.FindElement(USERMGMTVIEWUSERS).Click();
                dr.FindElement(USERMGMTADDBUTTON).Click();
            }
        }

    }
}
