/*
Author: Daniel Davidson
Date:   10/27/2019
CTEC 135: Microsoft Software Development with C# 

Module 5, Programming Assignment 4, Problem 3

    Dictionary

    *put all your code in main. 
    *Dictionary use
    - declare a dictionary and initialization it to create 3 entries: 
    * (1, "one"), (2, "two"), and (3, "three"). Use a combination of 
    * initialization syntax, Add() and [] in your initialization code.
    - add an additional entry: (99, "ninety-nine")
    - show use of enumerator to see all entries. Print both the key and value
    - reassign the value of 99 to "99" using indexing notation
    - print the new value using indexing notation
    - remove the 2 item and enumerate over the whole dictionary to show it's gone

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaring dictionary.
            IDictionary<int, string> entries = new Dictionary<int, string>();

            // initializing 3 entries.
            entries.Add(1, "One");
            entries.Add(2, "Two");
            entries.Add(3, "Three");
            entries.Add(99, "ninety-nine");

            // using enumerator to print key and value
            foreach (KeyValuePair<int, string> item in entries)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);
            }
            Console.WriteLine();

            //entries.Add(99, 99);

            // removing 99 and 3

            entries.Remove(99);
            entries.Remove(3);

            foreach (KeyValuePair<int, string> item in entries)
            {
                Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

            }
            Console.WriteLine("Two items are gone.");
            Console.WriteLine();

        }
    }
}
