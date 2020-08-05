using System;
using System.IO;

namespace Search_stupid_for_vk
{
    public static class CheckingPageAvailablity
    {
        public static Nullable<bool> ToCheckifThePageIsAvailable()
        {
            Nullable<bool> trueOrFalse;

            int count = File.ReadAllLines("parsingResult.txt").Length;
            if (count < 170)
            {
                trueOrFalse = true;
            }
            else
            {
                trueOrFalse = false;
            }

            return trueOrFalse;
        }
    }
}
