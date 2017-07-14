using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethod
    {
        //enter text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);

        }
        //click in a button,option ,chechkbox
        public static void Click(IWebElement element)
        {
            element.Click();
        }
        //selecting dropdown control
        public static void SelectDropdown(IWebElement element, string value)
        {


            new SelectElement(element).SelectByText(value);
        }
    }
}
