using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
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
            try
            {
                StreamWriter textFile = new StreamWriter("parsingResult.txt");
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

        public void WritingToTextFile(string textContent, string path)
        {
            try
            {
                StreamWriter textFile = new StreamWriter(path);
                textFile.WriteLine(textContent);
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

        public void ReadToTextFile(string path)
        {
            string[] wordForFindDumb = {"Kuat", "Electron", "Sex18", "Кымбат"}; // This is your blackword array or file
            foreach (var input in wordForFindDumb)
            {
                Console.WriteLine($"Found the word: {input}");
                IEnumerable<string> lines = File.ReadAllLines(path);

                Console.Write($"Enter the word {input} to search: ");

                IEnumerable<string> matches = !String.IsNullOrEmpty(input)
                    ? lines.Where(line => line.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                    : Enumerable.Empty<string>();

                Console.WriteLine(matches.Any()
                    ? String.Format("Matches:\n> {0}", String.Join("\n> ", matches))
                    : "There were no matches");
            }
        }


        public void RunEverything()
        {
            Console.WriteLine(Greeting());
            ReadToTextFile("parsingResult.txt");
        }
    }
}