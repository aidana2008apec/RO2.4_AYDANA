using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Gym membership System ---");

        Console.Write("Enter membership type: ");
        string type =
        Console.ReadLine();
        Console.Write("Number of months; ");
        int months = int.Parse(Console.ReadLine());
        Console.Write("Monthly fee: ");
        double fee = int.Parse(Console.ReadLine());
        Console.Write("Personal trainer fee: ");
        double coachFee = double.Parse(Console.ReadLine());
        Console.Write("Your height (maters): ");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Trainer's first letter: ");
        char trainerChar = char.Parse(Console.ReadLine());
        Console.Write("Is premium access? (true/false): ");
        bool premium = bool.Parse(Console.ReadLine());

        double baseCost = months * fee;
        double totalWithCoach = baseCost + coachFee;

        Console.WriteLine("\n--- Client Info ---");
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Months: " + months);
        Console.WriteLine("Fee: " + fee);
        Console.WriteLine("Coach Fee: " + coachFee);
        Console.WriteLine("Height: " + height);
        Console.WriteLine("Trainer letter: " + trainerChar);
        Console.WriteLine("Premium: " + premium);
        Console.WriteLine("\n--- Total Costs ---");
        Console.WriteLine("Base membership cost: " + baseCost);
        Console.WriteLine("Total with trainer: " + totalWithCoach);
       
    }
}