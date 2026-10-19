// See https://aka.ms/new-console-template for more information

using Bogus;
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("-- Працюю із Random --");
//Для генерації число Random можна взяти на C# його клас
Random r = new Random(); //r - це змінна, яка може робити випадкові величини
int age = r.Next(18, 60); //При цьому 18 ключно, 60 не включно
Console.WriteLine("Вік Random " + age);
//Особливість C# - дуже велика є кількість бібліотек,
//які хто написав, а Ви можете скористатися.
//Для втановлення бібліотеки використовуємо NuGet
//Для роботи з Bogus - ми кочинаємо з Faker
//Весь світ ідентифікує Україну, як uk
//Зараз зроблю for - мій улюблений цикл - як у С++
for (int i = 0; i < 10; i++)
{
    Faker myFaker = new Faker("uk"); //Я вказую мову для Faker
    string fullName = myFaker.Name.FullName(); // Це буде FullName
    Console.WriteLine("Full Name = " + fullName);
    string phone = myFaker.Phone.PhoneNumber();
    Console.WriteLine("Phone number = " + phone);
    string city = myFaker.Address.City();
    Console.WriteLine("Місто = " + city);
    string street = myFaker.Address.StreetName();
    Console.WriteLine("Вулиця = " + street);
}