// PrintLine();
// Console.WriteLine("Отчёт");
// PrintLine();

// Console.WriteLine("");
// PrintHeader("Книжка");

// Console.WriteLine("");
// PrintHeader("Тетрадка");

// int result = Max(5, 10);
// Console.WriteLine(result);
// int result2 = Max(15, 9);
// Console.WriteLine(result2);


// bool Even1 = IsEven(4);
// Console.WriteLine(Even1);
// bool Even2 = IsEven(7);
// Console.WriteLine(Even2);
// bool Even3 = IsEven(0);
// Console.WriteLine(Even3);

// int[] marks = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(SumArray(marks));
// Console.WriteLine(Average(marks));
// Console.WriteLine(CountGreater(marks, 100));

// double c1 = 0;
// double c2 = 100;
// double c3 = 37;
// Console.WriteLine($"{c1}°C = {ToFahrenheit(c1)}°F");
// Console.WriteLine($"{c2}°C = {ToFahrenheit(c2)}°F");
// Console.WriteLine($"{c3}°C = {ToFahrenheit(c3)}°F");

// Console.WriteLine(Factorial(5));

// for (int i = 2; i <= 50; i++)
// {
//     Console.WriteLine(IsPrime(i));
// }

// int num1 = ReadPositive("Введите первое число: ");
// int num2 = ReadPositive("Введите второе число: ");
// int sum = num1 + num2;
// Console.WriteLine($"Сумма ваших чисел: {sum}");


static void PrintLine()
{
    Console.WriteLine("^_^");
}


static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}


static int Max(int a, int b)
{
    if (a > b) { return a; } else { return b; }
}


static bool IsEven(int n)
{
    return n % 2 == 0;
}


static int SumArray(int[] arr)
{
    int sum = 0;
    foreach (int x in arr)
    {
        sum += x;
    }
    return sum;
}


static double Average(int[] arr)
{
    int sum = 0;
    foreach (int x in arr)
    {
        sum += x;
    }
    return (double)sum / arr.Length;
}


static int CountGreater(int[] arr, int limit)
{
    int counter = 0;
    foreach (int x in arr)
    {
        if (x > limit) { counter++; }
    }
    return counter;
}


static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}


static long Factorial(int n)
{
    long res = 1;
    for (int i = 1; i <= n; i++)
    {
        res *= i;
    }
    return res;
}


static bool IsPrime(int n)
{
    int counter2 = 0;
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0) { counter2++; }
    }
    return counter2 == 0;
}


static int ReadPositive(string message)
{
    while (true)
    {
        Console.Write(message);

        int number = Convert.ToInt32(Console.ReadLine());

        if (number > 0)
        {
            return number;
        }

        Console.WriteLine("Ошибка! Число должно быть строго больше 0.");
    }
}


// int select = 9;
// while (select != 0)
// {
//     Console.WriteLine("");
//     Console.WriteLine("Меню-калькулятор");
//     Console.WriteLine("");
//     Console.WriteLine("1 - сумма двух чисел");
//     Console.WriteLine("2 - больше из двух чисел");
//     Console.WriteLine("3 - факториал");
//     Console.WriteLine("0 - выход");
//     Console.WriteLine("");
//     Console.Write("Выберите операцию: ");
//     select = Convert.ToInt32(Console.ReadLine());
//     switch (select)
//     {
//         case 1:
//             {
//                 Console.Write("Введите первое число: ");
//                 int num1 = Convert.ToInt32(Console.ReadLine());
//                 Console.Write("Введите второе число: ");
//                 int num2 = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("");
//                 Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//                 break;
//             }
//         case 2:
//             {
//                 Console.Write("Введите первое число: ");
//                 int num1 = Convert.ToInt32(Console.ReadLine());
//                 Console.Write("Введите второе число: ");
//                 int num2 = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("");
//                 Console.WriteLine($"Большое число из {num1} и {num2}: {Max(num1, num2)}");
//                 break;
//             }
//         case 3:
//             {
//                 Console.Write("Введите число: ");
//                 int num1 = Convert.ToInt32(Console.ReadLine());
//                 Console.WriteLine("");
//                 Console.WriteLine($"{num1}! = {Factorial(num1)}");
//                 break;
//             }
//         default:
//             {
//                 Console.WriteLine("");
//                 Console.WriteLine("Нет такого пункта");
//                 break;
//             }
//     }
// }


static int Gcd(int a, int b)
{
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}


static int Lcm(int a, int b)
{
    return a / Gcd(a, b) * b;
}

Console.WriteLine(Gcd(48, 18));
Console.WriteLine(Lcm(4, 6));