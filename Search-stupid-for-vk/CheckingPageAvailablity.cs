using System;
using System.IO;

namespace Search_stupid_for_vk
{
    public static class CheckingPageAvailablity
    {
        public static Nullable<bool> ToCheckifThePageIsAvailable()
        {
            string[] pageIsBlock =
            {
                "Войдите на сайт или зарегистрируйтесь, чтобы связаться",
            };

            Nullable<bool> trueOrFalse = null;
            // var keyword = "Войдите на сайт или зарегистрируйтесь, чтобы связаться";
            foreach (var keyword in pageIsBlock)
            {
                using (var sr = new StreamReader("parsingResult.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        if (String.IsNullOrEmpty(line)) trueOrFalse = false;
                        if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0)
                        {
                            trueOrFalse = true;
                        }
                    }
                }

                break;
            }

            return trueOrFalse;
        }
    }
}
