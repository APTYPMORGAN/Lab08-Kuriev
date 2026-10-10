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

int num1 = ReadPositive("Введите первое число: ");
int num2 = ReadPositive("Введите второе число: ");
int sum = num1 + num2;
Console.WriteLine($"Сумма ваших чисел: {sum}");

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