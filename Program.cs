void PrintArray(string[] array) //печать массива

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов ");
int size = Convert.ToInt32(Console.ReadLine());

string[] arrayString = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    arrayString[i] = element;
}

string[] arrayFinal = new string[size];
int maxlength = 3;
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (arrayStrings[j].Length <= maxlength)
    {
        arrayFinal[pos] = arrayStrings[j];
        pos++;
    }
}

Console.WriteLine();
PrintArray(arrayFinal);