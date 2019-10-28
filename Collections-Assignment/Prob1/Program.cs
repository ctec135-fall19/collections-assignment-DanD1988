/*
Author: Daniel Davidson
Date:   10/27/2019
CTEC 135: Microsoft Software Development with C# 

Module 5, Programming Assignment 4, Problem 1

    Arrays and Lists

   * Put all your code in main. 
    *Regions
    1. Simple array:
        * create an array of int of size 5
        * use a for loop to initialize it to the numbers 11 - 15
        * use a foreach loop to print out the values in the array
    2. List<T>
        * create a list of int
        * use a for loop to initialize the list to the numbers 21 - 25
        * use a foreach loop to print out the values in the list
        * update the values in the list to 31 - 35 using indexing
        * repeat the print using a for loop and indexing

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            Console.WriteLine();

            #region 1 simple array 11-15
            Console.WriteLine("Simple array prints out 11-15:\n");

            // arrays 
            // declarations 
            int[] numbers = new int[5];

            // initializing and transversing through ints.
            for (int i=0; i < numbers.Length; i++)
            {
                numbers[i] = (i * 1) + 11;
            }

            // traversal to print out values in the array.
            foreach (int element in numbers)
            {
                Console.WriteLine(element);
            }
            
            Console.WriteLine();

            #endregion

            #region 2

            /*
             * create a list of int
             * use a for loop to initialize the list to the numbers 21 - 25
             * use a foreach loop to print out the values in the list
             * update the values in the list to 31 - 35 using indexing
             * repeat the print using a for loop and indexing
            */

            List<int> l = new List<int>();

            Console.WriteLine("Printing out numbers from 21-25:\n");
            // initializing
            // this is setting the values from 21-25

            l.Add(1);
            l.Add(2);
            l.Add(3);
            l.Add(4);
            l.Add(5);

            // element access
            
            for (int i = 0; i < l.Count; i++)
            {
                l[i] = (i * 1) + 21;
            }
           
            // printing out value from for loop
            foreach (int element in l)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();

            // updating values to 31-35 using indexing
            // element access

            l[0] = 31;
            l[1] = 32;
            l[2] = 33;
            l[3] = 34;
            l[4] = 35;

            // for loop is used to repeat the print
            Console.WriteLine("Updating values to 31-31, using indexing:\n");
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }
            Console.WriteLine();

            #endregion

        }
    }
}
