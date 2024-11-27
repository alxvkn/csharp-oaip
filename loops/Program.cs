using System;

class Program {
    static void _2() {
        Console.WriteLine("задание 2:");
        double a = 1.5, b = 1.2;
        for (double x = -0.75; x > -1.5; x -= 0.05) {
            Console.WriteLine(1.2 * Math.Pow(a - b, 3) * Math.Exp(Math.Pow(x, 2)) + x);
        }
    }

    static void _3() {
        Console.WriteLine("задание 3:");
        double a = 10.2, b = -1.5;
        for (double x = -0.5; x < 2.5; x += 0.05) {
            Console.WriteLine(Math.Pow(10, -1) * a * Math.Pow(x, 3) * Math.Tan(a - b * x));
        }
    }

    static void _4() {
        Console.WriteLine("задание 4:");
        double a = 1.35, b = -6.25;
        for (double x = 5.3; x < 10.3; x += 0.25) {
            Console.WriteLine(a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2));
        }
    }

    static void _5() {
        Console.WriteLine("задание 5:");
        double d = 1.3;
        for (double x = 4.6; x < 5.8; x += 0.2) {
            Console.WriteLine(Math.Pow(x, 4) + Math.Cos( 2 + Math.Pow(x, 3) -d));
        }
    }

    static void _6() {
        Console.WriteLine("задание 6:");
        double b = -0.8;
        for (double x = -1.5; x > -2.5; x -= 0.5) {
            Console.WriteLine(Math.Pow(x, 2) + Math.Tan(5 * x + (b / x)));
        }
    }

    public static void Main(string[] args) {
        _2();
        _3();
        _4();
        _5();
        _6();
    }
}
