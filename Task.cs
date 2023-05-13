int Input(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

string[] CreateArray()
 {
    int N = Input("Введите количество элементов массива: ");
    return new string [N];
 }

void FillByUser(string [] array)
{ 
    for (int i = 0; i < array.Length; i++)
    {
       Console.WriteLine("Введите элемент массива: ");
       array[i] = Console.ReadLine();
    }
} 

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

// void CountOfPositiveNumbers(int[]array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         count++;
//     }
// Console.WriteLine("Количество чисел больше 0: " + count);
// Console.WriteLine();
//add methods Input , CreateArray,  FillByUser,  PrintArray
// }

string [] arr = CreateArray();
FillByUser(arr);
PrintArray(arr);
