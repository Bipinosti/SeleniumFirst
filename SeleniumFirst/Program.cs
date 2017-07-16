using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            
        }
        [SetUp]
        public void initialize()
        {
            PropertiesCollection.driver = new ChromeDriver();
            PropertiesCollection.driver.Navigate().GoToUrl("file:///C:/Users/Bipin/Desktop/aj.html");
            Console.WriteLine("Url opened");

        }
        [Test]
        public void ExecuteTest()
        {
            ExcelLib.PopulateInCollection(@"E:\Data.xlsx");

            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA = pageLogin.Login(ExcelLib.ReadData(1, "UserName"), ExcelLib.ReadData(1, "Password"));
            pageEA.FillUserForm(ExcelLib.ReadData(1, "Initial"), ExcelLib.ReadData(1, "MiddleName"), ExcelLib.ReadData(1, "FirstName"));




            ////Login
            //LoginPageObject pageLogin = new LoginPageObject();
            //EAPageObject pageEA = pageLogin.Login("Bipin", "Osti");
            //pageEA.FillUserForm("Hello", "Bipin", "Osti");




            ////dropdown
            //SeleniumSetMethod.SelectDropdown("TitleId", "Mr.", PropertyType.Id);
            ////Initial name
            //SeleniumSetMethod.EnterText("Initial", "Hello", PropertyType.Name);

            //Console.WriteLine("The value i entered is : " + SeleniumGetMethod.GetTextFromDDL ( "TitleId", PropertyType.Id));
            //Console.WriteLine("The value i entered for initial is : " + SeleniumGetMethod.GetText( "Initial", PropertyType.Name));

            ////click operation
            //SeleniumSetMethod.Click("Save", PropertyType.Name);
            //SeleniumSetMethod.Click("Hindi", PropertyType.Name);
        }
        /* [TearDown]*/
        public void Cleanup()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("End of program");
        }
        
    }
}
