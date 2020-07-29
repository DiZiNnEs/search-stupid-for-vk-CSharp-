using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

// using System.Net.Http;
// using System.Threading.Channels;
// using System.Threading.Tasks;
// using AngleSharp;
// using AngleSharp.Dom;

namespace Search_stupid_for_vk
{
    public class TheFirstWayToFindDumb<T>
    {
        private string url;

        public TheFirstWayToFindDumb(string url)
        {
            this.url = url;
        }

        public string Greeting()
        {
            return $"I got a link: {url}\n" +
                   $"Searching for an asshole";
        }

        public async Task<string> GetHtml(string url)
        {
            using HttpClient httpClient = new HttpClient();
            string content = await httpClient.GetStringAsync(url);
            try
            {
                // StreamWriter textFile = new StreamWriter("parsingResult.txt");
                // textFile.Write(content);
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

        public void WritingToTextFile()
        {
            try
            {
                StreamWriter textFile = new StreamWriter("parsingResult.txt");
                textFile.WriteLine(GetHtml(url));
                textFile.Close();
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
        }

        // public void Write(string someText)
        // {
        //     try
        //     {
        //         StreamWriter textFile = new StreamWriter("parsingResult.txt");
        //         textFile.Write("Hell world");
        //         
        //         textFile.WriteLine(someText);
        //         textFile.Close();
        //     }
        //     catch (Exception e)
        //     {
        //         Console.WriteLine(e);
        //         throw;
        //     }
        // }
        // Сделать метод для записи результата парсинга в текстовый файл
        // Сделать метод для прочтение этого файла
    }
}