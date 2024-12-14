using System;

class ASCII_Calculator
{
    static void Main(string[] args)
    {
        // Baraye Neshon Dadan UI
        DisplayCalculatorUI();

        // Daryaft Vorodi Ha
        Console.Write("Avalin Adad Ra Vared Konid: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Amaliat Ra Entekhab Konid (+, -, *, /): ");
        string operation = Console.ReadLine();

        Console.Write("Dovomin Adad Ra Vared Konid: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Mohasebat Ro Anjam Mide
        double result = 0;
        bool validOperation = true;

        if (operation == "+")
        {
            result = num1 + num2;
        }
        else if (operation == "-")
        {
            result = num1 - num2;
        }
        else if (operation == "*")
        {
            result = num1 * num2;
        }
        else if (operation == "/")
        {
            if (num2 != 0)
            {
                result = num1 / num2;
            }
            else
            {
                Console.WriteLine("Ekhtar : Taghsim Bar 0 Taarif Nashode");
                validOperation = false;
            }
        }
        else
        {
            Console.WriteLine("Amaliat Movafghat amiz Nabod");
            validOperation = false;
        }

        // Agar ValidOperation True Bashe Khoroji Ro chaap Mikone
        if (validOperation)
        {
            Console.WriteLine($"Khoroji: {num1} {operation} {num2} = {result}");
        }

        Console.WriteLine("\nBaraye Khoroj Dokme i ro feshar bedid");
        Console.ReadKey();
    }

    // Baraye Namayesh Mashin Hesab
    static void DisplayCalculatorUI()
    {
        Console.Clear();
        Console.WriteLine("┌─────────────────────────────────────┐");
        Console.WriteLine("│         Mashin Hesabe ASCII         │");
        Console.WriteLine("│      ╔═════╦═════╦═════╦═════╗      │");
        Console.WriteLine("│      ║  7  ║  8  ║  9  ║  /  ║      │");
        Console.WriteLine("│      ╠═════╬═════╬═════╬═════╣      │");
        Console.WriteLine("│      ║  4  ║  5  ║  6  ║  *  ║      │");
        Console.WriteLine("│      ╠═════╬═════╬═════╬═════╣      │");
        Console.WriteLine("│      ║  1  ║  2  ║  3  ║  -  ║      │");
        Console.WriteLine("│      ╠═════╬═════╬═════╬═════╣      │");
        Console.WriteLine("│      ║  0  ║  .  ║  =  ║  +  ║      │");
        Console.WriteLine("│      ╚═════╩═════╩═════╩═════╝      │");
        Console.WriteLine("└─────────────────────────────────────┘");
        Console.WriteLine();
    }
}
