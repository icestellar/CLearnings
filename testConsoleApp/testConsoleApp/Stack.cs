using System;
using System.Collections.Generic;
using System.Text;

namespace testConsoleApp
{
    public class Stack
    {
        static readonly int MAX = 1000;
        int top = -1;
        int[] stack = new int[MAX];
       public bool isEmpty()
        {
            return (top < 0);
        }
         public int checkStack()
        {
            if (top >= MAX)
            {
                Console.WriteLine("Stack OVERflow");
                return -1;
            }
            if (top < 0)
            {
                Console.WriteLine("Stack UNDERflow");
                return -2;
            }
            return 0;
        }
        public bool Push(int data)
        {
            if (checkStack() != -1)
            {
                stack[++top] = data;
                return true;
            }
            else
            {
                return false;
            }
        }
        public int Pop()
        {
            if (checkStack() != -2)
            {
                return stack[top--];
            }
            else
            {
                return 0;
            }
            
        }
        public void Peek()
        {
            if (checkStack() == -2)
            {
                Console.WriteLine("Hey, I'm Empty");
                return;
            }
            else
            {
                Console.WriteLine($"The last item is: {stack[top]}");
            }
        }

        public void PrintStack()
        {
            for(int i = top; i>=0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }

    }
}
