using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Schreibe ein Programm das alle Zahlen von 1 bis 100 ausgibt. ... 
              Wenn die Zahl ein Vielfaches von 3 ist, soll statt der Zahl das Wort "Fizz" ausgegeben werden.
              Wenn die Zahl ein Vielfaches von 5 ist, soll statt der Zahl das Wort "Buzz" ausgegeben werden.
              Ist die Zahl sowohl ein Vielfaches von 3 als auch von 5, soll statt der Zahl das Wort "FizzBuzz"*/

            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine((i % 3 == 0) ? "Fizz" : (i % 5 == 0) ? "Buzz" : (i % 3 == 0) && (i % 5 == 0) ? "FizzBuzz" : i);
            }

            Console.WriteLine();
            Console.WriteLine("Programmende");
        }
    }
}
