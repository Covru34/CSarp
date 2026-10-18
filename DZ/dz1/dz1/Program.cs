using System.Runtime.InteropServices;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

// Завдання 1
int num;
Console.WriteLine("Введіть число від 1 до 100: ");
string temp1 = Console.ReadLine();
num = int.Parse(temp1);

if (num < 1 || num > 100)
{
    Console.Write("Ви ввели завелике число");
}
else if (num % 3 == 0 && num % 5 == 0)
{
    Console.Write("Fizz Buzz");
}
else if (num % 3 == 0)
{
    Console.Write("Fizz");
}
else if (num % 5 == 0)
{
    Console.Write("Buzz");
}
else
{
    Console.Write(num);
}
Console.WriteLine();

// Завдання 2
Console.WriteLine("Введіть число та відсоток: ");
string temp2 = Console.ReadLine();
string temp3 = Console.ReadLine();
double num2 = double.Parse(temp2);
double num3 = double.Parse(temp3);
double result2 = (num3 / 100) * num2;
Console.Write("Відсоток від числа: " + result2);
Console.WriteLine();

// Завдання 3
Console.WriteLine("Введіть три цифри: ");
string temp4 = Console.ReadLine();
string temp5 = Console.ReadLine();
string temp6 = Console.ReadLine();
int num4 = int.Parse(temp4);
int num5 = int.Parse(temp5);
int num6 = int.Parse(temp6);
Console.WriteLine(num4 + "" + num5 + "" + num6);

// Завдання 4
Console.WriteLine("Введіть шестизначне число та номери розрядів для обміну цифр: ");
string temp7 = Console.ReadLine();
string temp8 = Console.ReadLine();
string temp9 = Console.ReadLine();
int num7 = int.Parse(temp7);
int pos1 = int.Parse(temp8);
int pos2 = int.Parse(temp9);

if (num7 > 999999 || num7 < 100000)
{
    Console.WriteLine("Введіть шестизначне число");
    return;
}

if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6)
{
    Console.WriteLine("Помилка: номери розрядів повинні бути від 1 до 6!");
    return;
}

int d1 = num7 / 100000;
int d2 = num7 / 10000 % 10;
int d3 = num7 / 1000 % 10;
int d4 = num7 / 100 % 10;
int d5 = num7 / 10 % 10;
int d6 = num7 % 10;

long resultTask4 = 0;
for (int i = 1; i <= 6; i++)
{
    int currentPos = i;

    if (i == pos1) currentPos = pos2;
    else if (i == pos2) currentPos = pos1;

    int digit = currentPos switch
    {
        1 => d1,
        2 => d2,
        3 => d3,
        4 => d4,
        5 => d5,
        6 => d6,
        _ => 0
    };

    resultTask4 = resultTask4 * 10 + digit;
}
Console.WriteLine(resultTask4);

// Завдання 5
Console.Write("Введіть дату (формат: dd.MM.yyyy, наприклад 22.12.2021): ");
string inputDate = Console.ReadLine();
if (DateTime.TryParse(inputDate, out DateTime dt))
{
    int month = dt.Month;
    string season = "";

    if (month == 12 || month == 1 || month == 2)
        season = "Winter";
    else if (month >= 3 && month <= 5)
        season = "Spring";
    else if (month >= 6 && month <= 8)
        season = "Summer";
    else
        season = "Autumn";

    string dayOfWeek = dt.DayOfWeek.ToString();
    Console.WriteLine($"{season} {dayOfWeek}");
}
else
{
    Console.WriteLine("Некоректний формат дати!");
}

// Завдання 6
Console.Write("Введіть значення температури: ");
double tempVal6 = double.Parse(Console.ReadLine());
Console.WriteLine("Оберіть напрямок переведення:");
Console.WriteLine("1 — з Фаренгейта в Цельсій");
Console.WriteLine("2 — з Цельсія в Фаренгейт");
int choice = int.Parse(Console.ReadLine());

if (choice == 1)
{
    double celsius = (tempVal6 - 32) * 5.0 / 9.0;
    Console.WriteLine($"Результат: {celsius:F2} °C");
}
else if (choice == 2)
{
    double fahrenheit = (tempVal6 * 9.0 / 5.0) + 32;
    Console.WriteLine($"Результат: {fahrenheit:F2} °F");
}
else
{
    Console.WriteLine("Невірний вибір.");
}

// Завдання 7
Console.Write("Введіть перше число: ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введіть друге число: ");
int end = int.Parse(Console.ReadLine());

if (start > end)
{
    int tempSwap7 = start;
    start = end;
    end = tempSwap7;
}

Console.WriteLine($"Парні числа в діапазоні від {start} до {end}:");
for (int i = start; i <= end; i++)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}\t");
    }
}
Console.WriteLine();

// Завдання 8
Console.Write("Введіть число: ");
string inputStr8 = Console.ReadLine();
int number8 = int.Parse(inputStr8);
int length8 = inputStr8.Length;
int sum8 = 0;
int tempLoop8 = number8;

while (tempLoop8 > 0)
{
    int digit = tempLoop8 % 10;
    int power = 1;
    for (int i = 0; i < length8; i++)
    {
        power *= digit;
    }

    sum8 += power;
    tempLoop8 /= 10;
}

if (sum8 == number8)
{
    Console.WriteLine($"Число {number8} є числом Армстронга.");
}
else
{
    Console.WriteLine($"Число {number8} НЕ є числом Армстронга.");
}

// Завдання 9
Console.Write("Введіть число: ");
int number9 = int.Parse(Console.ReadLine());
int sum9 = 0;
for (int i = 1; i < number9; i++)
{
    if (number9 % i == 0)
    {
        sum9 += i;
    }
}

if (sum9 == number9 && number9 > 0)
{
    Console.WriteLine($"Число {number9} є досконалим.");
}
else
{
    Console.WriteLine($"Число {number9} НЕ є досконалим.");
}