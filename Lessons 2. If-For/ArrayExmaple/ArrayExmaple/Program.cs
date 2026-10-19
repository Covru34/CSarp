// See https://aka.ms/new-console-template for more information
using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("--Хочу працювати із масивами--");

//Масив набір однопитних даних
int[] mas = { 12, 34, 19, 22, 9 };
//Як отримати скільки елементів є у масив
int n = mas.Length; //Length - це кількість елементів
Console.WriteLine("Розмір масиву = " + n);
//Читання масиву, як у С++
//Я можу йти по масиву через for
for (int i = 0; i < n; i++)
{
    //через {} можна у рядок підставляти змінні
    Console.Write($"{mas[i]}\t");//$ - форматований рядок 
}
Console.WriteLine(); //Для \n після вмісту масива

Console.Write("Який розмір масиву: ");
int count = int.Parse(Console.ReadLine());
//Як виділити пам'ять під масив, який створюється динамічно
//int *myArray = new int[count]; - C++
int[] myArray = new int[count]; //Так на С#
//Хочу заповнити масив числами від 1 до 20 - вкилючно 
Random r = new Random();
//Працюю через цикл for
for (int i = 0; i < count; i++)
    myArray[i] = r.Next(0, 21);
Console.WriteLine("У нас вийшов такий масив");
for (int i = 0; i < count; i++)
{
    Console.Write($"{myArray[i]}\t");
}

//Хочу масив відсортувати
//Візьму 2 цикли і по проходу 2 циклу,
//буду знаходити максимальний і ставити
//його на певну позицію у масиві 
for (int i = 0; i < count - 1; i++) //Цикл i кінця не доходить
{
    for (int j = i + 1; j < count; j++) //починається з i+1 для сортування
    {
        if (myArray[i] > myArray[j])
        {
            //міняємо місцями i та j елемент
            int temp = myArray[i]; //запам'ятали i
            myArray[i] = myArray[j];
            myArray[j] = temp; //поміняли елементи місцями
        }
    }
}

Console.WriteLine("\n--Відсортований масив--");
//Можна через for, але хочу через foreach
foreach (int item in myArray)
{
    Console.Write($"{item}\t");
}
Console.WriteLine();

Console.WriteLine("--Робота циклу foreach, як можна уявити--");
//Можете собі приблизно уявити, що цикл foreach
//працює десь ось так
for (int i = 0; i < myArray.Length; i++)
{
    int item = myArray[i];
    Console.Write($"{item}\t");
}
Console.WriteLine();