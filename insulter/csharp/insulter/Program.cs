﻿using System;
using System.Collections.Generic;

namespace insulter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> AllInsults = new List<string>()
            {
                "You look like what morning breath smells like.",
                "If you tried to give me cpr I would probably throw myself back under water",
                "I am not a fan of you",
                "You think you're so special...and you are. The fact of your existence is nearly impossible to believe",
                "I'd rather walk than be on the same plane as you",
                "If I were given a million dollars to hang out with you...I would, but then I'd have to spend half of it on therapy",
                "Do you have to be so...like that?"
            };

            List<int> InsultsIndex = new List<int>();

            while (InsultsIndex.Count < 3)
            {
                int RandomNumber = new Random().Next(0, AllInsults.Count - 1);
                if (!InsultsIndex.Contains(RandomNumber))
                {
                    InsultsIndex.Add(RandomNumber);
                }
            }

            for (int i = 0; i < InsultsIndex.Count; i++)
            {
                Console.WriteLine(AllInsults[InsultsIndex[i]]);
            }
        }
    }
}
