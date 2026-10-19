// See https://aka.ms/new-console-template for more information

//Встановлюємо кодування, щоб працювала укр мова
using System.Text;

Console.InputEncoding = Encoding.UTF8; //Щоб вводити на укр мові
Console.OutputEncoding = Encoding.UTF8; //Щоб вивід працювало укр.мова
Console.WriteLine("Оператори умови схожий на С++");
/*
//string - вбудований, працює відразу чудово
string name;
Console.Write("Як Вас звати: ");//Виводить текст на екран
//cin>>name; //аналог С++ cin
name = Console.ReadLine(); 
Console.WriteLine("Привіт друже "+name); //виводить текст із '\n'
*/ //як у С++

int age = 0; //Вік людини
Console.Write("Скільки Вам років: ");
string temp = Console.ReadLine(); //Вводимо текст з клавіатури
//Ми маємо перетворити temp у тип даних int, бо age - це int
age = int.Parse(temp); //Петеворимо temp у int
Console.WriteLine("Ваш вік: " + age); //Виводимо вік людини

//Дуже чудово, що if працює як у С++
//Оператори порівняння >, <, >=, <=, !=, ==, !
if (age <= 0) //якщо вік менше нуля
{
    Console.WriteLine("Вік не можу бути меншим 0 :(");
}
//Є також оператор
//|| - або - хиба, якщо 2 разом хиба,
//&& - і - істини, якщо 2 разом істина
//Перевірю умову чи людина - є дитина - до садочка
if (age > 0 && age < 3) //умова з ліва і з права має бути вірною
{
    Console.WriteLine("Дитина, ще у садочок не ходить :)");
}
if (age >= 3 && age < 6)
{
    Console.WriteLine("Вітаємо Ви ходити в садочок :)");
}
if (age >= 6 && age < 18)
{
    Console.WriteLine("Ви школяр :)");
}
if (age >= 18 && age < 23)
{
    Console.WriteLine("Ви студент :)");
}
//Якщо ми маємо умову на приклад a%2 == 0; //чи парне число
//Якщо я хочу перевірити чи число не парне, я можу взяти заперечення
int a = 35;
if (a % 2 == 0)
    Console.WriteLine("a парне число");
if (!(a % 2 == 0))
    Console.WriteLine("a число не парне");