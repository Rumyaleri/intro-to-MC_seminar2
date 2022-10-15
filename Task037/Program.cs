// задача 37.
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат записать в новом массиве.


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int [size];
    var rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max+1);
    }
    return array;
} 

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] SumElements (int[] array)
{
    int siz = array.Length / 2;
    if (array.Length % 2 == 1) siz = siz + 1;
    int[] newArr = new int[siz];
    for (int i = 0; i < size; i++)
    {
        newArr[i] = array[i] * array[array.Length -1 - i];
    }
    return newArr;
}

int[] arr = CreateArrayRndInt(21, 0, 999);
PrintArray(arr);

int[] newArray = SumElements (arr);
PrintArray(newArray);