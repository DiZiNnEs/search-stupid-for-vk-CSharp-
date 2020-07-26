using System;
using System.IO;
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

        public string GetHtml()
        {
            // Using asynchrony 
            // HttpClient httpClient = new HttpClient();
            // string url = await httpClient.GetStringAsync(this.url);
            // IConfiguration config = Configuration.Default;
            // IBrowsingContext context = BrowsingContext.New(config);
            // IDocument document = await context.OpenAsync(request => request.Content(url));
            //
            // var got = document.Links;
            // foreach (var VARIABLE in got)
            // {
            //     Console.WriteLine(VARIABLE.TextContent);
            // }
            //
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

            return readStream.ReadToEnd();
        }
    }
}