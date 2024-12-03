class OneDimensional
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

    static void _7() {
        Console.WriteLine("Задание 7.");
        int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };

        uint count = 0;
        int sum = 0;
        foreach (int n in arr) {
            if (n % 5 == 0 && n % 7 != 0) {
                sum += n;
                count++;
            }
        }

        Console.WriteLine(count);
        Console.WriteLine(sum);
        Console.WriteLine();
    }

    static void _8() {
        Console.WriteLine("Задание 8.");
        double[] arr = { 1, 1.2, 2, -4, 1.9, 0.5, 7, 8, 9, 10, -11, 12, 13, 14, -15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 25 };

        uint n_negative = 0;
        uint n_in_interval = 0;

        foreach (int n in arr) {
            if (n < 0) {
                n_negative++;
            } else if (n >= 1 && n <= 2) {
                n_in_interval++;
            }
        }

        Console.WriteLine($"Меньше нуля: {n_negative}");
        Console.WriteLine($"Принадлежат интервалу [1, 2]: {n_in_interval}");
        Console.WriteLine();
    }

    static void _9() {
        Console.WriteLine("Задание 9.");

        int[] arr = {
            1, 2, 3, 4, 5,
            1, 2, 3, 4, 5,
            1, 2, 3, 4, 5,
            1, 2, 3, 4, 5,
            1, 2, 3, 4, 5,
            1, 2, 3, 4, 5,
            1, 2, 3, 4, 5,
        };

        int s = 0;
        int p = 1;
        foreach (int n in arr) {
            if (n % 2 == 0) {
                if (n < 3)
                    s += n;
            } else {
                if (n > 1)
                    p *= n;
            }
        }

        int r = s + p;

        Console.WriteLine(r);
        Console.WriteLine();
    }

    static void _10() {
        Console.WriteLine("Задание 10.");

        uint[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, };

        foreach (uint n in arr) {
            if (n % 7 == 1 || n % 7 == 2 || n % 7 == 5) {
                Console.WriteLine(n);
            }
        }

        Console.WriteLine();
    }
    
    public static void run() {
        Console.WriteLine("Одномерные массивы.");
        _1();
        _2();
        _3();
        _4();
        _5();
        _6();
        _7();
        _8();
        _9();
        _10();
    }
}

class MultiDimensional {
    static void _1() {
        Console.WriteLine("Задание 1.");
        int[,] mat = {
            { 1, 2, 3, 4 },
            { 5, 6, -1, 5 },
            { 10, 15, 8, 90 },
        };

        for (uint i = 0; i < mat.GetLength(0); i++) {
            for (uint j = 0; j < mat.GetLength(1); j++) {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }

        for (uint i = 0; i < 3; i++) {
            int min = mat[i, 0];

            for (uint j = 1; j < 4; j++) {
                if (mat[i, j] < min) {
                    min = mat[i, j];
                }
            }

            Console.WriteLine($"Минимальный элемент строки {i + 1} = {min}");
            Console.WriteLine();
        }
    }

    static void _2() {
        Console.WriteLine("Задание 2.");

        int [,] mat = {
            {1,2,3},
            {5,6,7},
            {3,8,4},
        };

        for (uint i = 0; i < mat.GetLength(0); i++) {
            for (uint j = 0; j < mat.GetLength(1); j++) {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }

        int row_2_sum = 0;
        for (uint j = 0; j < mat.GetLength(1); j++) {
            row_2_sum += mat[1, j];
        }

        Console.WriteLine($"Сумма элементов второй строки: {row_2_sum}");

        int col_1_prod = 1;
        for (uint i = 0; i < mat.GetLength(0); i++) {
            col_1_prod *= mat[i, 0];
        }
        Console.WriteLine($"Произведение элементов первого столбца: {col_1_prod}");
        Console.WriteLine();
    }

    static void _3() {
        Console.WriteLine("Задание 3.");

        double [,] mat = {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, },
        };

        for (uint i = 0; i < mat.GetLength(0); i++) {
            for (uint j = 0; j < mat.GetLength(1); j++) {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }

        double sum = 0;
        for (uint i = 0, j = 0; i < mat.GetLength(0) && j < mat.GetLength(1); i++, j++) {
            sum += mat[i, j];
        }

        if (sum > 10) {
            for (uint i = 0; i < mat.GetLength(0); i++) {
                for (uint j = 0; j < mat.GetLength(1); j++) {
                    mat[i, j] = mat[i, j] + 13.5;
                }
            }
        } else {
            for (uint i = 0; i < mat.GetLength(0); i++) {
                for (uint j = 0; j < mat.GetLength(1); j++) {
                    mat[i, j] = mat[i, j] * 2 - 1.5;
                }
            }
        }

        Console.WriteLine($"S: {sum}");
        for (uint i = 0; i < mat.GetLength(0); i++) {
            for (uint j = 0; j < mat.GetLength(1); j++) {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }

    static void _4() {
        Console.WriteLine("Задание 4.");

        double [,] mat = {
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
        };

        for (uint i = 0; i < mat.GetLength(0); i++) {
            for (uint j = 0; j < mat.GetLength(1); j++) {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }

        uint line = 0;
        for (; line < mat.GetLength(0); line++) {
            if (mat[line, 0] == 1) {
                break;
            }
        }

        if (mat[line, 0] != 1) {
            Console.WriteLine("Строки нет");
            return;
        }

        double sum = 0;
        for (uint j = 0; j < mat.GetLength(1); j++) {
            sum += mat[line, j];
        }

        double avg = sum / mat.GetLength(1);

        Console.WriteLine($"Среднее арифметическое строки номер {line + 1}: {avg}");

        Console.WriteLine();
    }

    static void _5() {
        Console.WriteLine("Задание 5.");

        int[,] mat = {
            { 1, 2, 3, 4, 5, 6, 7, },
            { 1, 2, 3, 4, 5, 6, 7, },
            { 1, 2, 3, 4, 5, 6, 7, },
            { 1, 4, 2, 4, 5, 6, 7, },
            { 1, 2, 3, 4, 1, 3, 2, },
            { 1, 2, 3, 4, 5, 6, 7, },
            { 1, 2, 3, 4, 5, 6, 7, },
        };

        for (uint i = 0; i < mat.GetLength(0); i++) {
            for (uint j = 0; j < mat.GetLength(1); j++) {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }

        for (uint j = 0; j < mat.GetLength(1); j++) {
            int min = mat[0, j];

            for (uint i = 0; i < mat.GetLength(0); i++) {
                if (mat[i, j] < min) {
                    min = mat[i, j];
                }
            }

            Console.WriteLine($"Наименьший элемент столбца {j + 1}: {min}");
        }

        Console.WriteLine();
    }

    static void _6() {
        Console.WriteLine("Задание 6.");

        int [,] mat = {
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 0, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, },
        };

        for (uint i = 0; i < mat.GetLength(0); i++) {
            for (uint j = 0; j < mat.GetLength(1); j++) {
                Console.Write($"{mat[i, j]} ");
            }
            Console.WriteLine();
        }

        int min = mat[0, 0];
        uint row = 0;
        for (uint i = 0, j = 0; i < mat.GetLength(0) && j < mat.GetLength(1); i++, j++) {
            if (mat[i, j] < min) {
                min = mat[i, j];
                row = i;
            }
        }
        Console.WriteLine($"Минимальный элемент главной диагонали находится на строке {row + 1} и равен {min}");
        Console.WriteLine("Вся строка: ");
        for (uint j = 0; j < mat.GetLength(1); j++) {
            Console.Write($"{mat[row, j]} ");
        }

        Console.WriteLine();
    }


    public static void run() {
        Console.WriteLine("Многомерные массивы.");

        _1();
        _2();
        _3();
        _4();
        _5();
        _6();
    }
}

class Program {
    public static void Main(string[] args) {
        // OneDimensional.run();
        MultiDimensional.run();
    }
}
