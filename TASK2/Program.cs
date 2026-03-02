using System;

class Program
{
    static void Main()
    {
        //Ex 1
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num1 == num2)
        {
            Console.WriteLine("The numbers are equal.");
        }
        else if (num1 > num2)
        {
            Console.WriteLine("The first number is greater than the second.");
        }
        else
        {
            Console.WriteLine("The first number is less than the second.");
        }

        //task 2
        Console.WriteLine("Введите число: ");
        double n = double.Parse(Console.ReadLine());

        if (n > 5 && n < 10)
        {
            Console.WriteLine("The number is greater than 5 and less than 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        //task 3
        Console.Write("Enter a number: ");
        double n1 = double.Parse(Console.ReadLine());

        if (n1 == 5 || n1 == 10)
        {
            Console.WriteLine("The number is either 5 or 10");
        }
        else
        {
            Console.WriteLine("Unknown number");
        }

        //task 4

        Console.Write("Enter the deposit amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double interest;
        if (amount < 100)
        {
            interest = amount * 0.05;
        }
        else if (amount >= 100 && amount <= 200)
        {
            interest = amount * 0.07;
        }
        else
        {
            interest = amount * 0.10;
        }
        double total = amount + interest;
        Console.WriteLine("Total amount including interest: " + total);

        //task 5

        Console.Write("Enter the deposit amount: ");
        double amount1 = Convert.ToDouble(Console.ReadLine());

        double interest1;
        double bonus1 = 15;
        if (amount1 < 100)
        {
            interest1 = amount1 * 0.05;
        }
        else if (amount1 >= 100 && amount1 <= 200)
        {
            interest1 = amount1 * 0.07;
        }
        else
        {
            interest1 = amount1 * 0.10;
        }
        double total1 = amount + interest1 + bonus1;
        Console.WriteLine("Final amount (Interest + Bonus): " + total1);

        //task 6
        Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Addition");
                break;
            case 2:
                Console.WriteLine("Subtraction");
                break;
            case 3:
                Console.WriteLine("Multiplication");
                break;
            default:
                Console.WriteLine("Operation is undefined");
                break;

              
        }
        Console.WriteLine("Enter operation number: 1.Addition 2.Subtraction 3.Multiplication");
        int choice1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the first number: ");
        double num7 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num8 = Convert.ToDouble(Console.ReadLine());
        double result2;
        switch (choice1)
        {
            case 1:
                result2 = num7 + num8;
                Console.WriteLine("Result: " + result2);
                break;

            case 2:
                result2 = num7 - num8;
                Console.WriteLine("Result: " + result2);
                break;

            case 3:
                result2 = num7 * num8;
                Console.WriteLine("Result: " + result2);
                break;

            default:
                Console.WriteLine("Operation is undefined");
                break;
        }
    }
}