using System;
namespace inlamning3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in två tal");
            string answer = Console.ReadLine();
            int space = answer.IndexOf(" ");
            int number1 = int.Parse(answer[..space]);
            int number2 = int.Parse(answer[space..]);

            Console.WriteLine("Välj ett räknesätt");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            string method = Console.ReadLine();

            switch (method)
            {
                case "1":
                    int addition = number1 + number2;
                    Console.WriteLine($"{number1} plus {number2} blir {addition}");
                    break;

                case "2":
                    int subtraction = number1 - number2;
                    Console.WriteLine($"{number1} minus {number2} blir {subtraction}");
                    break;

                case "3":
                    int multiplication = number1 * number2;
                    Console.WriteLine($"{number1} gånger {number2} blir {multiplication}");
                    break;

                case "4":
                    double division = (double)number1 / (double)number2;
                    Console.WriteLine($"{number1} dividerat med {number2} blir {division}");
                    break;

            }
            Console.ReadKey();  
        
        }


    }

}
