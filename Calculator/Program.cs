using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables for equation
            double result = 0;
            double firstNumber = SetNumber("Type you first number : ");
            double secondNumber = SetNumber("Type you second number: ");

            string stringOperation =
                SetOperation(
                    "Enter the operation + (addition), - (subtraction), * (multiplication), / (division), % (Remainder));
    
            //This is my main menu
                Console.WriteLine("***********Calculator Menu ************");
            Console.WriteLine("1: Addition (+)");
            Console.WriteLine("1: Subtraction (-)");
            Console.WriteLine("1: Multiplication (x)");
            Console.WriteLine("1: Division (/)");
            Console.WriteLine("1: Remainder (%)");
            Console.WriteLine("1: Exit");

            //if else statements 



            var operationChoice = Console.ReadLine();
            while(operationChoice != "6")
            {

                decimal a = GetOperandA();
                decimal b = GetOperandB();
                Console.WriteLine(DoCalculation());

            }
        }
    }
}
