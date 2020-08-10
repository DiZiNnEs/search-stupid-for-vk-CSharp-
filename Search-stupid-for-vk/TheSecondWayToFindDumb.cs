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
        public async Task<string>  cssDemo()
        {
            m_driver = new FirefoxDriver(Environment.CurrentDirectory);
            m_driver.Url = url;
            m_driver.Manage().Window.Minimize();
            var test = m_driver.FindElement(By.CssSelector(""));
            var test3 = test.GetAttribute("innerHTML");
            // var link = m_driver.FindElement(By.XPath("//span[contains(text)), \"Following\")]"));
            var link = m_driver.FindElement(By.CssSelector("span.header_label.fl_l:nth-child(1)"));
            var test2 = link.GetAttribute("innerHTML");
            link.Click();
            foreach (var VARIABLE in test3)
            {
                Console.WriteLine(VARIABLE);
            }
            // using HttpClient httpClient = new HttpClient();
            // string content = await httpClient.GetStringAsync(link);
            return test3; 
            // m_driver.Close();
        }
        
        // public async Task<string> GetHtml()
        // {
        //     using HttpClient httpClient = new HttpClient();
        //     string content = await httpClient.GetStringAsync(cssDemo());
        //     try
        //     {
        //         StreamWriter textFile = new StreamWriter("parsingResultFromSeleniumBrowser.txt");
        //         textFile.Write(content);
        //     }
        //     catch (DirectoryNotFoundException ex)
        //     {
        //         throw new DirectoryNotFoundException("Directory not found!");
        //     }
        //     // Catch another exception
        //     catch (Exception ex)
        //     {
        //         throw new Exception();
        //     }
        //
        //     return content;
        // }
    }
}