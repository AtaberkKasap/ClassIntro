﻿using System;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();

            myDictionary.Add(1, "Ataberk");

            Console.WriteLine(myDictionary.Count);
        }
    }
}
