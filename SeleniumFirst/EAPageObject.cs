using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }






        [FindsBy(How = How.Id, Using = "TitleId")]

        public IWebElement ddlTitleId { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]

        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]

        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]

        public IWebElement txtMiddleName { get; set; }


        [FindsBy(How = How.Name, Using = "Hindi")]

        public IWebElement btnhindi { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]

        public IWebElement btnSave { get; set; }

        public void FillUserForm(String Initial , String FirstName , String MiddleName)
        {
            txtInitial.EnterText(Initial);
            txtFirstName.EnterText(FirstName);
            txtMiddleName.EnterText(MiddleName);
            btnhindi.Clicks();
            btnSave.Clicks();


            //SeleniumSetMethod.EnterText(txtInitial, Initial);
            //SeleniumSetMethod.EnterText(txtFirstName, FirstName);
            //SeleniumSetMethod.EnterText(txtMiddleName, MiddleName);
            //SeleniumSetMethod.Clicks(btnhindi);
            //SeleniumSetMethod.Clicks(btnSave);

        }


    }
}
