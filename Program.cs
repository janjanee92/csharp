using System;

namespace CSharp
{

    class Program 
    {

        static void Main(string[] args)
        {
            string name = "Harry Potter";

            bool found = name.Contains("Harry");
            int index = name.IndexOf('P');

            string lowerCaseName = name.ToLower();
            Console.WriteLine(lowerCaseName);

            name = name.Replace('a', 'z');

            string[] names = name.Split(new char[] { ' ' });
            string sub = name.Substring(5);
        }
    }
}
