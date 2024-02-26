using System;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        int correctAnswers = 0;

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1 - Multiplication");
            Console.WriteLine("2 - Division");
            Console.WriteLine("3 - Exit");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (MultiplicationProblem())
                        correctAnswers++;
                    break;
                case 2:
                    if (DivisionProblem())
                        correctAnswers++;
                    break;
                case 3:
                    Console.WriteLine($"Congratulations, you got {correctAnswers} right.");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }

    static bool MultiplicationProblem()
    {
        int num1 = random.Next(1, 11);
        int num2 = random.Next(1, 11);
        int num3 = random.Next(1, 11);

        Console.WriteLine($"A bricklayer stacks bricks in {num1} rows, with {num2} bricks in each row. On top of each row, there is a stack of {num3} bricks.");
        Console.Write("How many bricks are there in total? ");
        int answer = int.Parse(Console.ReadLine());

        if (answer == (num1 * num2 + num3))
        {
            Console.WriteLine("Correct!");
            return true;
        }
        else
        {
            Console.WriteLine($"Sorry, the correct answer is {num1 * num2 + num3}.");
            return false;
        }
    }

    static bool DivisionProblem()
    {
        int totalTickets = random.Next(50, 101);
        int costPerRide = random.Next(3, 9);

        Console.WriteLine($"If you have {totalTickets} tickets for the fair and each ride costs {costPerRide} tickets, how many rides can you go on?");
        Console.Write("Enter your answer: ");
        int answer = int.Parse(Console.ReadLine());

        if (answer == totalTickets / costPerRide)
        {
            Console.WriteLine("Correct!");
            return true;
        }
        else
        {
            Console.WriteLine($"Sorry, the correct answer is {totalTickets / costPerRide}.");
            return false;
        }
    }
}
