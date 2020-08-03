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
            c.WritingToTextFile(await c.GetHtml(vkPage));
            c.RunEverything();

            CheckingPageAvailablity.ToCheckifThePageIsAvailable();
            if (CheckingPageAvailablity.ToCheckifThePageIsAvailable())
            {
                Console.WriteLine("page is private");
            }
            else if (CheckingPageAvailablity.ToCheckifThePageIsAvailable() == false)
            {
                Console.WriteLine("page isn't private ");
            }
            else
            {
                Console.WriteLine("Fuck you, I don't know what's going on");
            }

            Console.WriteLine(CheckingPageAvailablity.ToCheckifThePageIsAvailable());
        }
    }
}
