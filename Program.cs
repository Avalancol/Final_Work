//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.

Console.Clear();
Console.Write("Количество строк в исходном массиве: ");
int countStr = int.Parse(Console.ReadLine()!);

string[] Strings = new string[countStr];
for (int i = 0; i < countStr; i++)
{
    Console.Write($"Cтрока {i + 1}:");
    Strings[i] = Console.ReadLine()!;
}

Console.Write($"\n[\"{String.Join("\", \"", Strings)}\"]");
Console.Write(" --> ");
Console.WriteLine($"[\"{String.Join("\", \"", FilterMassive(Strings))}\"]");


//-----------функция-----------------------------------------------------------------------
string[] FilterMassive(string[] array)
{
    string[] newArray = new string[array.Length];
    int count = 0;
    foreach (string element in array)
    {
        if (element.Length <= 3)
        {
            newArray[count] = element;
            count++;
        }
    }
    string[] finArray = new string[count];
    for (int i = 0; i < count; i++)
        finArray[i] = newArray[i];
    return finArray;
}