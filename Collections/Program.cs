﻿using System;
using System.Collections.Generic;

namespace Collections

{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            string[] names = new string[] { "Engin", "Murat", "Kerem", "Halil" }; //4 elements   --> 101
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            
            names = new string[5]; // new reference --> 5 elements with new adresses     --> 102
            names[4] = "İlker";
            Console.WriteLine(names[4]);
            Console.WriteLine(names[0]);
            */

            List<string> names2 = new List<string>{"Engin", "Murat", "Kerem", "Halil" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("İlker");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            
            
        }
    }
}
