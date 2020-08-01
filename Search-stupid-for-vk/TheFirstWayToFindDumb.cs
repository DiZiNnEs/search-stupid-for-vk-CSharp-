using System;
using System.Collections.Generic;
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

        public async void WritingToTextFile(string textContent)
        {
            try
            {
                StreamWriter textFile = new StreamWriter("parsingResult.txt");
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
        // Сделать метод для прочтение этого файла

        public void ReadToTextFile()
        {
            string[] wordForFindDumb = {"Kuat", "Electron", "Sex18"};

            // string[] lines = File.ReadAllLines("parsingResult.txt");
            // foreach (string line in lines)
            //     Console.WriteLine(line);
            // Console.WriteLine("FIND THE WORD");
            // Console.Write("Keyword: ");
            // var keyword = Console.ReadLine() ?? "";
            // using (var sr = new StreamReader("parsingResult.txt")) {
            //     while (!sr.EndOfStream) {
            //         var line = sr.ReadLine();
            //         if (String.IsNullOrEmpty(line)) continue;
            //         if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0) {
            //             Console.WriteLine(line);
            //         }
            //     }
            // }
            //We read all the lines from the file
//             IEnumerable<string> lines = File.ReadAllLines("parsingResult.txt");
//
// //We read the input from the user
//             Console.Write("Enter the word to search: ");
//             string input = Console.ReadLine().Trim();
//             // var input = wordForFindDumb;
//
// //We identify the matches. If the input is empty, then we return no matches at all
//             IEnumerable<string> matches = !String.IsNullOrEmpty(input)
//                 ? lines.Where(line => line.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
//                 : Enumerable.Empty<string>();
//
// //If there are matches, we output them. If there are not, we show an informative message
//             Console.WriteLine(matches.Any()
//                 ? String.Format("Matches:\n> {0}", String.Join("\n> ", matches))
//                 : "There were no matches");

            foreach (var input in wordForFindDumb)
            {
                Console.WriteLine($"Found the word: {input}");
                //We read all the lines from the file
                IEnumerable<string> lines = File.ReadAllLines("parsingResult.txt");

//We read the input from the user
                Console.Write("Enter the word to search: ");
                // string input = Console.ReadLine().Trim();

//We identify the matches. If the input is empty, then we return no matches at all
                IEnumerable<string> matches = !String.IsNullOrEmpty(input)
                    ? lines.Where(line => line.IndexOf(input, StringComparison.OrdinalIgnoreCase) >= 0)
                    : Enumerable.Empty<string>();

//If there are matches, we output them. If there are not, we show an informative message
                Console.WriteLine(matches.Any()
                    ? String.Format("Matches:\n> {0}", String.Join("\n> ", matches))
                    : "There were no matches");
            }
        }
    }
}
