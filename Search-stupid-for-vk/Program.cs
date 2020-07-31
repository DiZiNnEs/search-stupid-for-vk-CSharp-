using System;
using System.Threading.Tasks;

namespace Search_stupid_for_vk
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, I find stupid people on VK");
            Console.WriteLine("Enter the link to the VK page");
            string vkPage = Console.ReadLine();

            TheFirstWayToFindDumb<string> c = new TheFirstWayToFindDumb<string>(vkPage);
            Console.WriteLine(c.GetHtml(vkPage));
            c.WritingToTextFile(await c.GetHtml(vkPage));

        }
    }
}