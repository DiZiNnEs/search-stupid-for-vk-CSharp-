using System;
using System.Net.Http;
using System.Threading.Channels;

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
    }
}