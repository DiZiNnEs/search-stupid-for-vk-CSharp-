using System;
using System.IO;

namespace Search_stupid_for_vk
{
    public class CheckingPageAvailablity
    {

        public static void ToCheckifThePageIsAvailable()
        {
            bool trueOrFalse = true;
            var keyword = "Страница доступна только авторизованным пользователям";
            using (var sr = new StreamReader("parsingResult.txt")) {
                while (!sr.EndOfStream) {
                    var line = sr.ReadLine();
                    if (String.IsNullOrEmpty(line)) trueOrFalse = true;
                    if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        trueOrFalse = false;
                    }
                }
            }
        }
    }
}
