using System;

namespace CSharp
{
    class Program 
    { 
        static int Add(int a, int b, int c = 0, float f = 1.0f, double d = 3.0)
        {
            return a + b + c;
        }

        static void Main(string[] args)
        {
            Add(1, 2, d: 2.0);
        }
    }
}
