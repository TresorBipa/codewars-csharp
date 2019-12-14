﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using CodeWars;

namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string[], string> bisics = new Dictionary<string[], string>()
            {
                {new []{"Mike", "Millington"},  "Malware Mike"},
                {new []{"Fahima", "Tash"},"Function T-Rex"},
                {new []{"Daisy", "Petrovic"},"Data Payload"},
                {new []{"Barny", "White"},"Beta Worm"},
                {new []{"Hank", "Kutz"},"Half-life Killer"},
                {new []{"123abc", "Pinkman"},"Your name must start with a letter from A - Z."}
            };

            foreach (KeyValuePair<string[], string> keyValuePair in bisics)
            {
                Console.WriteLine(CrashOverride.AliasGen(keyValuePair.Key[0], keyValuePair.Key[1]));
            }

        }
    }
}
