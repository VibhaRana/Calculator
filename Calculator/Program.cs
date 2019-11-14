

using System;

namespace Calculator
{
    class Program
    {

        static void Main(string[] args)
        {

            decimal num1;
            decimal num2;
            string operand;
            decimal answer;
            while (true)
            {
                Console.WriteLine("Please enter the first number: ");
                num1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Please enter an operand (+, -, /, *,%): ");
                operand = Console.ReadLine();

                Console.WriteLine("Please enter the second integer: ");
                num2 = Convert.ToDecimal(Console.ReadLine());

                switch (operand)
                {

                    case "-":
                        answer = num1 - num2;
                        break;

                    case "+":
                        answer = num1 + num2;
                        break;

                    case "/":
                        answer = num1 / num2;
                        break;

                    case "*":
                        answer = num1 * num2;
                        break;
                    case "%":
                        answer = num1 % num2;
                        break;


                    default:
                        answer = 0;
                        break;
                }
                Console.WriteLine(num1.ToString() + " " + operand + " " + num2.ToString() + " = " + answer.ToString());
               
                
                if (Console.ReadLine().ToLower() == "exit")
                {
                    break;
                }
            }
            Console.ReadLine();
        }

    }
}

