using System;
using System.Net.Http;
using System.Threading.Channels;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;

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

        public async Task GetHtml()
        {
            HttpClient httpClient = new HttpClient();
            string url = await httpClient.GetStringAsync(this.url);
            IConfiguration config = Configuration.Default;
            IBrowsingContext context = BrowsingContext.New(config);
            IDocument document = await context.OpenAsync(request => request.Content(url));

            var got = document.Links;
            foreach (var VARIABLE in got)
            {
                Console.WriteLine(VARIABLE.TextContent);
            }
        }
    }
}