using System.Text;

Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("--Масив випадкових чисел та сортування бульбашкою--");


Console.Write("Який розмір масиву: ");
int count = int.Parse(Console.ReadLine());
int[] myArray = new int[count];

Random r = new Random();
for (int i = 0; i < count; i++)
    myArray[i] = r.Next(0, 21); // від 0 до 20 включно (21 не входить)

Console.WriteLine("Масив до сортування:");
for (int i = 0; i < count; i++)
{
    Console.Write($"{myArray[i]}\t");
}
Console.WriteLine();


for (int i = 0; i < count - 1; i++) // кількість проходів
{
    for (int j = 0; j < count - 1 - i; j++) // останні i елементів вже на місці
    {
        if (myArray[j] > myArray[j + 1])
        {
            // міняємо місцями сусідів
            int temp = myArray[j];
            myArray[j] = myArray[j + 1];
            myArray[j + 1] = temp;
        }
    }
}


Console.WriteLine("\n--Відсортований масив: цикл for--");
for (int i = 0; i < myArray.Length; i++)
{
    Console.Write($"{myArray[i]}\t");
}
Console.WriteLine();

Console.WriteLine("\n--Відсортований масив: цикл while--");
int k = 0; // лічильник для while створюємо самі
while (k < myArray.Length)
{
    Console.Write($"{myArray[k]}\t");
    k++; // не забуваємо збільшувати, інакше цикл буде нескінченним
}
Console.WriteLine();

Console.WriteLine("\n--Відсортований масив: цикл foreach--");
foreach (int item in myArray)
{
    Console.Write($"{item}\t");
}
Console.WriteLine();
