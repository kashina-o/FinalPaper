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

void ResultArray(string []array)
{
    int lenResultArray = 0;
    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i].Length <= 3) lenResultArray++;
    }

    string[] resultArray = new string[lenResultArray];
    int index = 0;

    for (int i = 0; i <= array.Length - 1; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[index] = array[i];
            index++;
        }
    }
PrintArray(resultArray);
}

string [] arr = CreateArray();
FillByUser(arr);
PrintArray(arr);
ResultArray(arr);