double chois;
do
{
    Console.WriteLine("Выбирите какую операцию вы хотите выполнить:");
    Console.WriteLine("1. Сложить два числа");
    Console.WriteLine("2. Вычесть первое из второго");
    Console.WriteLine("3. Перемножить два числа");
    Console.WriteLine("4. Разделить первое на второе");
    Console.WriteLine("5. Возвести в степень N первое число");
    Console.WriteLine("6. Найти квадратный корень из числа");
    Console.WriteLine("7. Найти 1 процент из числа");
    Console.WriteLine("8. Найти факториал из числа");
    Console.WriteLine("9. Выйти из программы");
    chois = Convert.ToDouble(Console.ReadLine());
    if (chois == 9)
    {
        break;
    }
    double a;
    double b;
    double result;
    if (chois == 1)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());
        result = a + b;
        Console.WriteLine("Результат" + "\n" + result);
    }
    if (chois == 2)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());
        result = a - b;
        Console.WriteLine("Результат" + "\n" + result);
    }
    if (chois == 3)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());
        result = a * b;
        Console.WriteLine("Результат" + "\n" + result);
    }
    if (chois == 4)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());
        if (b != 0)
        {
            result = a / b;
            Console.WriteLine("Результат" + "\n" + result);
        }
        else
        {
            Console.WriteLine("Деление на ноль не допустимо");
        }

    }
    if (chois == 5)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите второе число:");
        b = Convert.ToDouble(Console.ReadLine());
        result = Math.Pow(a, b);
        Console.WriteLine("Результат" + "\n" + result);
    }
    if (chois == 6)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToDouble(Console.ReadLine());
        if (a > 0)
        {
            result = Math.Sqrt(a);
            Console.WriteLine("Результат" + "\n" + result);
        }
        else
        {
            Console.WriteLine("Отрицательное число");
        }

    }
    if (chois == 7)
    {
        Console.WriteLine("Введите первое число");
        a = Convert.ToDouble(Console.ReadLine());
        result = a / 100;
        Console.WriteLine("Результат" + "\n" + result);
    }
    if (chois == 8)
    {
        Console.WriteLine("Введите первое число");
        int n = int.Parse(Console.ReadLine());
        if (n < 0)
        {
            Console.WriteLine("Отрицательное число");
        }
        else
        {
            result = CalculateFactorial(n);
            Console.WriteLine("Результат" + "\n" + result);
        }
    }
} while (chois != 9);
static double CalculateFactorial(int n)
{
    if (n == 0)
        return 1;

    double result = 1;
    for (int i = 1; i <= n; i++)
    {
        result *= i;
    }

    return result;
}