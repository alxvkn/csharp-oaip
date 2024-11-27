using System;

public class Program {
    static void _2()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введите номер операции:\n1.Сложение\n2.Вычитание\n3.Умножение");

        uint choice = Convert.ToUInt16(Console.ReadLine());

        if (choice == 1)
        {
            Console.WriteLine(a + b);
        }
        else if (choice == 2)
        {
            Console.WriteLine(a - b);
        }
        else if (choice == 3)
        {
            Console.WriteLine(a * b);
        }
        else
        {
            Console.WriteLine("Операция не определена.");
        }
    }

    static void _3()
    {
        Console.Write("Введите сумму вклада: ");
        double deposit = Convert.ToDouble(Console.ReadLine());

        double rate = 0;
        if (deposit < 100)
        {
            rate = 0.05;
        }
        else if (deposit >= 100 && deposit <= 200)
        {
            rate = 0.07;
        }
        else if (deposit > 200)
        {
            rate = 0.10;
        }

        Console.WriteLine($"Вклад с начисленными процентами: {deposit + (deposit * rate)}");
    }

    public static void Main(string[] args) {
        _2();
        _3();
    }
}
