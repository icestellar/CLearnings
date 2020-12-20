using System;

namespace TestingObjectArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectList obj = new ObjectList(5);
            obj.AddPlus(
                new ObjectList(4),
                new ObjectList(4));
            obj.ShowThis();
            Console.ReadLine();
        }
    }
}
