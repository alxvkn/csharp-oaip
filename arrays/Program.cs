namespace arrays;

class Program
{
    static void _1() {
        Console.WriteLine("Задание 1.");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        uint max_i = 0;
        for (uint i = 0; i < arr.Length; i++) {
            if (arr[i] > arr[max_i]) {
                max_i = i;
            }
        }

        int temp = arr[0];
        arr[0] = arr[max_i];
        arr[max_i] = temp;

        foreach (int n in arr) {
            Console.WriteLine(n);
        }
        Console.WriteLine();
    }

    static void _2() {
        Console.WriteLine("Задание 2.");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        uint min_i = 0;
        for (uint i = 0; i < arr.Length; i++) {
            if (arr[i] < arr[min_i]) {
                min_i = i;
            }
        }

        int temp = arr[8];
        arr[8] = arr[min_i];
        arr[min_i] = temp;

        foreach (int n in arr) {
            Console.WriteLine(n);
        }
        Console.WriteLine();
    }

    static void _3() {
        Console.WriteLine("Задание 3.");
        int[] f = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };

        double[] p = new double[f.Length];

        for (uint i = 0; i < f.Length; i++) {
            double pi = (0.13 * f[i] * 3) - (2.5 * f[i]) + 8;
            p[i] = pi;
            Console.WriteLine(p[i]);
        }
        Console.WriteLine();

        foreach (double pi in p) {
            if (pi < 0) {
                Console.WriteLine(pi);
            }
        }
        Console.WriteLine();
    }

    static void _4() {
        Console.WriteLine("Задание 4.");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

        for (uint i = 0; i < arr.Length; i++) {
            if (arr[i] < 0) {
                arr[i] *= arr[i];
            } else if (arr[i] > 0) {
                arr[i] += 7;
            }
        }

        foreach (int n in arr) {
            Console.WriteLine(n);
        }
        Console.WriteLine();
    }

    static void _5() {
        Console.WriteLine("Задание 5.");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        int sum = 0;
        foreach (int n in arr) {
            sum += n % 5 == 0 ? n : 0;
        }

        Console.WriteLine(sum);
        Console.WriteLine();
    }

    static void _6() {
        Console.WriteLine("Задание 6.");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        int sum = 0;
        foreach (int n in arr) {
            sum += (n % 2 != 0 && n < 0) ? n : 0;
        }

        Console.WriteLine(sum);
        Console.WriteLine();
    }
    
    static void Main(string[] args)
    {
        _1();
        _2();
        _3();
        _4();
        _5();
        _6();
    }
}
