using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
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

        [Test]
        public void cssDemo()
        {
            m_driver = new FirefoxDriver(Environment.CurrentDirectory);
            m_driver.Url = url;
            m_driver.Manage().Window.Maximize();
            // var link = m_driver.FindElement(By.XPath("//span[contains(text)), \"Following\")]"));
            var link = m_driver.FindElement(By.CssSelector("span.header_label.fl_l:nth-child(0)"));
            
            link.Click();
            m_driver.Close();
        }
    }
}