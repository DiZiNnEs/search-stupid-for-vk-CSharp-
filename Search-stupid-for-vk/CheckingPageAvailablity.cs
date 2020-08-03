using System;
using System.IO;

namespace Search_stupid_for_vk
{
    public static class CheckingPageAvailablity
    {
        public static bool ToCheckifThePageIsAvailable()
        {
            bool trueOrFalse = false;
            var keyword = "Страница доступна только авторизованным пользователям";
            using (var sr = new StreamReader("parsingResult.txt")) {
                while (!sr.EndOfStream) {
                    var line = sr.ReadLine();
                    if (String.IsNullOrEmpty(line)) trueOrFalse = false;
                    if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        trueOrFalse = true;
                    }
                }
            }

            return trueOrFalse;
        }
    }
}
