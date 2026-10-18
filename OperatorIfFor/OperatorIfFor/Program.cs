//Встановлюємо кодування щоб працювала Українська мова

using System.Text;

Console.InputEncoding = Encoding.UTF8; //Щоб вводити на укр мові
Console.OutputEncoding = Encoding.UTF8;// Щоб вивід працював укр мова
Console.WriteLine("Оператори уиови схожі на С++");
/*
// string вбудований, підключати не потрібно
string name;

Console.Write("Як вас звати?: ");//виводимо текст на екран
//cin >> name;
name = Console.ReadLine();

Console.WriteLine("Привіт друже " + name); // виводить текст із '\n'
*/

int age = 0; // Вік людини
Console.Write("Скількі вам років?: ");
string temp = Console.ReadLine(); // Вводимо текст з клавіатури
//Ми маємо перетворити temp у тип даних int, бо age - це int
age = int.Parse(temp); //Перетворимо temp у int
Console.WriteLine("Ваш вік: " + age); // Виводимо вік дюдини

// Дуже чудово, що if працює як у С++
// Оператори порвіняння: >, <, <=, >=, !=, ==
if(age <= 0)
{
    Console.WriteLine("Вік не може бути менше нуля");
}

// є також оператор
// || - або - хиба, якщо 2 разом хиба
// && - і - істини, якщо 2 різі істина
// Перевіряю умову чи людина - є дитина - до садочка
if(age > 0 && age < 3)
{

}