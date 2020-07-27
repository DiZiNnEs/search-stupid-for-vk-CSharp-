using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

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

        public string[] GetHtml()
        {
            HttpWebRequest request = (HttpWebRequest) WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            Stream receiveStream = response.GetResponseStream();
            StreamReader readStream = null;

            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (String.IsNullOrWhiteSpace(response.CharacterSet))
                    readStream = new StreamReader(receiveStream);
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
            }

            try
            {
                StreamWriter textFile = new StreamWriter("parsingResult.txt");
                textFile.Write(readStream.ReadToEnd());
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new DirectoryNotFoundException("Directory not found!");
            }

            return new[] {readStream.ReadToEnd()};
        }

        public void ComputingTheIdiot()
        {
            string[] blackListOfWords = {"Kuat", "Electron"};

            foreach (var blackWord in GetHtml())
            {
                if (blackListOfWords.Contains("div"))
                {
                    Console.WriteLine("I'm found!" + blackWord);
                }
                else
                {
                    Console.WriteLine("I didn't find black word)");
                }
            }

            Console.WriteLine(Array.Exists(GetHtml(), element => element == "div"));
        }
    }
}