﻿using System;
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

            TheSecondWayToFindDumb<string> c2 = new TheSecondWayToFindDumb<string>("https://vk.com/dizinnes");
            c.WritingToTextFile(await c.GetHtml(vkPage), "parsingResult.txt");

            CheckingPageAvailablity.ToCheckifThePageIsAvailable();
            if (CheckingPageAvailablity.ToCheckifThePageIsAvailable() == true)
            {
                Console.WriteLine("VK page is private");
            }
            else if (CheckingPageAvailablity.ToCheckifThePageIsAvailable() == false)
            {
                c.RunEverything();
                c2.RunEverythingForSecondWay();
            }
        }
    }
}