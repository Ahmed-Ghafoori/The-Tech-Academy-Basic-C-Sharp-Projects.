using System;

namespace MathOperationApp
{
    // Define a class that will contain the math operation method.
    public class MathOperations
    {
        // Define a void method that takes two integers as parameters.
        public void doMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer and display the second integer to the screen.
            Console.WriteLine("The first number doubled is: " + (firstNumber * 2));
            Console.WriteLine("The second number is: " + secondNumber);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class.
            MathOperations mathOperations = new MathOperations();

            // Call the method in the class, passing in two numbers.
            mathOperations.doMathOperation(5, 10);

            // Call the method in the class, specifying the parameters by name.
            mathOperations.doMathOperation(firstNumber: 20, secondNumber: 30);
        }
    }
}