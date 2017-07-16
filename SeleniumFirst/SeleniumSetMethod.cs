using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    public static class SeleniumSetMethod
    {
        /// <summary>
        /// Extended method for entering text in control.
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void EnterText(this IWebElement element, string value)
        {
            element.SendKeys(value);

        }



        /// <summary>
        ///click in a button,option ,chechkbox 
        /// </summary>
        /// <param name="element"></param>
        public static void Clicks(this IWebElement element)
        {
            element.Click();
        }

        /// <summary>
        ///selecting dropdown control 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        public static void SelectDropdown(this IWebElement element, string value)
        {


            new SelectElement(element).SelectByText(value);
        }
    }
}
