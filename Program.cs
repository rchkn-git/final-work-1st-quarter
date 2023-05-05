Console.Write("Введите длину массива: ");
int N = int.Parse(Console.ReadLine()!);

string[] ArrSTR = GetStrArray(N);
string[] FinalArray = new string[0];
FinalArray = FillFinalArray(ArrSTR, FinalArray);

Console.WriteLine("Первый массив: ");
PrintArray(ArrSTR);
Console.WriteLine();
Console.WriteLine("Итоговый массив: ");
PrintArray(FinalArray);
Console.WriteLine();

string[] GetStrArray(int n)
{
    string[] res = new string[n];

    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите " + (i+1) + " строку");
        res[i] = Console.ReadLine();
    }
    return res;
}

string[] FillFinalArray(string[] array, string[] finalArray)
{
    int j = 0;
    for (int i = 0; i < N; i++)
    {
        if (array[i].Length <=3)
        {
            Array.Resize(ref finalArray, finalArray.Length + 1);
            finalArray[j] = array[i];
            j++;
        } 
    }
    return finalArray;    
}

void PrintArray(string[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}
