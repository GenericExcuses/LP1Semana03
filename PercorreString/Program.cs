using System;

namespace PercorreString
{
    class Program
    {
        static void Main(string[] args)
        {

            String userString;
            char r;

            Console.WriteLine("Qual é a string?");
            userString = Console.ReadLine();
            Console.WriteLine("Qual é o caracter?");
            r = char.Parse(Console.ReadLine());

            foreach(char c in userString)
            {
                if (c != r)
                {

                    Console.Write(c);

                }

            }


        }
    }
}
