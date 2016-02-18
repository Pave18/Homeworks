using System;
using System.Collections.Generic;

namespace hw6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            string[] words;

            Console.WriteLine(" 1.The text of the example.  2.Enter your text.");
            
            int caseSwitch = Convert.ToInt32(Console.ReadLine());
            switch (caseSwitch)
            {
                case 1:
                    text = "How We Picked the 52 Places to Go in 2016 Each January, the editors of the Travel section publish our Places to Go issue. And each year after we do, readers wonder why their favorite destination was overlooked or why their least favorite made the top 10. To add some clarity to the process, we’ve decided to answer some frequently asked questions about how we chose our 52 Places to Go in 2016.nn How do you start the process?  First we contact dozens of contributing writers, many of them based overseas, for suggestions. We receive a few hundred ideas, and start with those.  What are you looking for in those ideas?  We aim for a selection of places that we expect to be particularly compelling in the coming year; reasons might include a museum opening, a new transportation option or a historical anniversary. So even though cities like Paris, Rome and Tokyo are always exciting, they didn’t make the cut.  How do you narrow it down to the final list?  We discuss the merits and drawbacks of each suggested destination in a marathon-length meeting (or two) before cutting down the list. Our main goal is to have a variety of regions and interests, with some surprises mixed in. We also try for a mix of scale, including cities, regions and even entire countries.";
                    words = TextToWords(text);
                    CountWords(words);
                    break;
                case 2:
                    text = Convert.ToString(Console.ReadLine());
                    words = TextToWords(text);
                    CountWords(words);
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
        }

        static string[] TextToWords(string Text)
        {
            string[] seperators = { " ", ".", "!", "?", ",", ";", "\"", "(", ")" };
            string[] Words = Text.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
            return Words;
        }

        static void CountWords(string[] words)
        {
            SortedDictionary<string, int> dict = new SortedDictionary<string, int>();

            foreach (string w in words)
            {
                int val;
                if (!dict.TryGetValue(w.ToLower(), out val))
                    dict[w.ToLower()] = 1;
                else
                    ++dict[w.ToLower()];
            }

            Console.WriteLine("Word\t\tQuantity ");
            foreach (KeyValuePair<string, int> p in dict)
                if (p.Key.Length < 8)
                    Console.WriteLine($"{p.Key}\t\t{p.Value}");
                else
                    Console.WriteLine($"{p.Key}\t{p.Value}");
        }

    }
}
