/*
Author: Daniel Davidson
Date:   10/27/2019
CTEC 135: Microsoft Software Development with C# 

Module 5, Programming Assignment 4, Problem 2

    Stacks and Queues

   * Put all your code in main. 
    *Regions
    1. Stack
    * declare and initialize a stack with the numbers 1 - 5 
      using initialization syntax.
    * demonstrate use of the enumerator to print out the members
      in the stack, i.e. write a foreach loop
    * print a peek at the top member in the stack
    * write a loop that pops the elements off of the stack and prints each

    2. Queue
    * declare a queue
    * initialize the queue with the numbers 1-5 using a for loop.
    * demonstrate use of the enumerator to print out the members in the     
      queue, i.e. write a foreach loop
    * print a peek at the top member in the stack
    * write a loop that dequeues the elements from the stack and prints each

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 1 Stack
            Console.WriteLine("------ Stack ------\n");
            // declare and initialize a stack with the numbers 1 - 5 
            // using initialization syntax.

            Stack<int> stackOfInts = new Stack<int>();

            stackOfInts.Push(5);
            stackOfInts.Push(4);
            stackOfInts.Push(3);
            stackOfInts.Push(2);
            stackOfInts.Push(1);

            // demonstrate use of the enumerator to print out the members
            //in the stack, i.e.write a foreach loop
            Console.WriteLine("Using enumerator to print out numbers");
            Console.WriteLine();
            foreach (int i in stackOfInts)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            // print a peek at the top member in the stack

            Console.WriteLine("Top member of stack is: {0}", stackOfInts.Peek());
            Console.WriteLine();

            // write a loop that pops the elements off of the stack and 
            // prints each

            int size = stackOfInts.Count;
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(stackOfInts.Pop());
            }
            Console.WriteLine();

            #endregion

            #region 2 Queue
            // declare a queue

            Console.WriteLine("------ QUEUE ------");
            Console.WriteLine();

            Queue<int> qtQueue = new Queue<int>();

            // adding elements to the queue
            qtQueue.Enqueue(1);
            qtQueue.Enqueue(2);
            qtQueue.Enqueue(3);
            qtQueue.Enqueue(4);
            qtQueue.Enqueue(5);

            // demonstrate use of the enumerator to print out the      
            // members in thequeue
            Console.WriteLine("Using of enumerator" +
                "to print numbers\n");
            foreach (int i in qtQueue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            // print a peek at the top member in the stack

            Console.WriteLine("Top member of stack is: {0}", qtQueue.Peek());
            Console.WriteLine();

            // write a loop that dequeues the elements from the stack and prints each

            qtQueue.Dequeue();
            qtQueue.Dequeue();
            qtQueue.Dequeue();
            qtQueue.Dequeue();
            qtQueue.Dequeue();

            foreach (int i in qtQueue)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            /*
            try
            {
                qtQueue.Dequeue();
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine("Error! {0}", e.Message);

            }
            */

            #endregion
        }
    }
}
