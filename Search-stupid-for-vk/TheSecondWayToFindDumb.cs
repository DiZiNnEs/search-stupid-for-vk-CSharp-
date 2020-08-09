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

        [Test]
        public async Task<IWebElement>  cssDemo()
        {
            m_driver = new FirefoxDriver(Environment.CurrentDirectory);
            m_driver.Url = url;
            m_driver.Manage().Window.Minimize();
            // var link = m_driver.FindElement(By.XPath("//span[contains(text)), \"Following\")]"));
            var link = m_driver.FindElement(By.CssSelector("span.header_label.fl_l:nth-child(1)"));
            
            link.Click();
            // using HttpClient httpClient = new HttpClient();
            // string content = await httpClient.GetStringAsync(link);
            return link; 
            // m_driver.Close();
        }
        
        public async Task<string> GetHtml()
        {
            using HttpClient httpClient = new HttpClient();
            string content = await httpClient.GetStringAsync(cssDemo());
            try
            {
                StreamWriter textFile = new StreamWriter("parsingResultFromSeleniumBrowser.txt");
                textFile.Write(content);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException("Directory not found!");
            }
            // Catch another exception
            catch (Exception ex)
            {
                throw new Exception();
            }

            return content;
        }
    }
}