// See https://aka.ms/new-console-template for more information

using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("Привіт! Робимо TryParse :)");

Console.WriteLine("Вкажіть Ваш вік:");
string strAge = Console.ReadLine();
int age = 15;
//Параметр out - означає, що змінна має змінити значення
//обов'язково
//bool isParse = int.TryParse(strAge, out age);
bool isParse = MyTryParse(strAge, out age);
if (isParse)
{
    Console.WriteLine($"Вік вказано вірно {age}");
}
else
{
    Console.WriteLine($"Помилка значення не валідне {age}");
}

bool MyTryParse(string str, out int value)
{
    value = 0; //у методі обов'язково має змінити value
    //3i8 - 38
    //usudow8fdfd9eee - 89
    string buffer = "";
    int len = str.Length; //довжина вхідного рядка
    for (int i = 0; i < len; i++)
    {
        //перевіряємо чи символ у рядку є число
        char ch = str[i]; //як перевіри чи це цифра
        int chInt = (int)ch; //Це буде код символа у таблиці кодування
        if (chInt >= 48 && chInt <= 57)
        {
            buffer += ch;//Зберігаю у буфер цифру
        }
    }
    if (buffer.Length == 0)
        return false;
    value = int.Parse(buffer);
    return true;
}