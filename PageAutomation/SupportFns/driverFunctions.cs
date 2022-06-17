using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageAutomation.SupportFns
{
    class driverFunctions
    {

        IWebDriver dr;
        public driverFunctions(IWebDriver driver)
        {
            this.dr = driver;
        }

        public String GetText(String elementType, String locator)
        {
            String text;
                
            if (elementType.ToLower() == "id")
            {
                dr.Dispose();
                text = this.dr.FindElement(By.Id(locator)).Text;
            }

            else if (elementType.ToLower() == "name")
            {

                text = dr.FindElement(By.Name(locator)).Text;
            }
            else if (elementType.ToLower() == "xpath")
            {
                text = dr.FindElement(By.XPath(locator)).Text;
            }

            else
            {
                throw new ElementNotVisibleException();
            }
            return text;
        }




        public Boolean GetTextAndValidate(String elementType, String locator, String validationvalue)
        {
            bool validaton = false;
            if (elementType.ToLower() == "id")
            {
                String text = GetText("id", locator);
                if (text.ToLower().Trim().Equals(validationvalue.ToLower().Trim()))
                {
                    validaton = true;
                }
            }

            else if (elementType.ToLower() == "name")
            {

                String text = GetText("name", locator);
                if (text.ToLower().Trim().Equals(validationvalue.ToLower().Trim()))
                {
                    validaton = true;
                }
            }
            else if (elementType.ToLower() == "xpath")
            {
                String text = GetText("xpath", locator);
                if (text.ToLower().Trim().Equals(validationvalue.ToLower().Trim()))
                {
                    validaton = true;
                }
            }

            else
            {
                validaton = false;
                throw new ElementNotVisibleException();
            }
            return validaton;
        }

        public Boolean TextValidation(String refValue, String validationvalue)
        {
            bool validaton = false;

            if (refValue.ToLower().Trim().Equals(validationvalue.ToLower().Trim()))
            {
                validaton = true;
            }
            else
            {
                validaton = false;
                throw new ElementNotVisibleException();
            }
            return validaton;
        }
    }
}
