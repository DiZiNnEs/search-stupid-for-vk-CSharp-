using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


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
            Console.WriteLine(123);
            Console.WriteLine(123);
            try
            {
                StreamWriter textFile = new StreamWriter("parsingResult.txt");
                textFile.Write(content);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex);
                throw new DirectoryNotFoundException("Directory not found!");
            }
            // Catch another exception
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw new Exception();
            }

            return content;
        }

        public async void WritingToTextFile(string textContent)
        {
            try
            {
                Console.WriteLine("I will write");
                StreamWriter textFile = new StreamWriter(textContent);
                textFile.Write(await GetHtml(url));
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

        // Сделать метод для прочтение этого файла
    }
}