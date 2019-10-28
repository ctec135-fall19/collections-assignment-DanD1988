/*
Author: Daniel Davidson
Date:   10/27/2019
CTEC 135: Microsoft Software Development with C# 

Module 5, Programming Assignment 4, Problem 4

    Linked List

    * LinkedList use
    - Demonstrate use of constructor taking an IEnumerable object.
    - Create a string array having the first 5-10 words of your 
      favorite nursery rhyme.
    - Use it as the argument when constructing the LinkedList object.
    - Print out the rhyme on a single line.
The traditional way to walk a linked list is to start at the head, process the node, then set the node variable to the next node in the list. Create a node variable and walk the list to print out the values. The line printed should be the same as the one above.
Remove a word from the middle of the list. Print the list on a single line to demonstrate this
Add the word back in and print the list again to demonstrate.


 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode<string> rhyme = new LinkedListNode<string>("Twinkle");
            Console.WriteLine("Twinkle Twinkle");
            Console.WriteLine();

            // creating the linked list 

            LinkedList<string> nr = new LinkedList<string>();
            nr.AddFirst(rhyme);

           
            // string array with first ten words of rhyme
            nr.AddLast("Twinkle");
            nr.AddLast("little");
            nr.AddLast("star");
            nr.AddLast("How");
            nr.AddLast("I");
            nr.AddLast("wonder");
            nr.AddLast("what");
            nr.AddLast("you");
            nr.AddLast("are");

            // 
            LinkedListNode<string> node = nr.First;
            while (node != null)
            {
                Console.WriteLine("   {0}", node.Value);
                node = node.Next;
            }
            Console.WriteLine();
        }
    }
}
