using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;


namespace Search_stupid_for_vk
{
    public class TheSecondWayToFindDumb<T>
    {
        private IWebDriver m_driver;

        private string url;

        public TheSecondWayToFindDumb(string url)
        {
            this.url = url;
        }
        public string GetPageFromSesleniumTest()
        {
            m_driver = new FirefoxDriver(Environment.CurrentDirectory);
            m_driver.Url = url;
            m_driver.Manage().Window.Minimize();
            try
            {
                var link = m_driver.FindElement(By.CssSelector("span.header_label.fl_l:nth-child(1)"));
                return m_driver.PageSource;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                m_driver.Close();
            }
        }

        public void RunEverythingForSecondWay()
        {
            TheFirstWayToFindDumb<string> call = new TheFirstWayToFindDumb<string>(url);
            call.WritingToTextFile(GetPageFromSesleniumTest(), "parsingResultFromSelenium.txt");
            call.ReadToTextFile("parsingResultFromSelenium.txt");
        }
    }
}