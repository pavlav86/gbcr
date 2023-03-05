string[] GetArrayWithThreeSymbols(string[] arr)
{
    string[] secondArr = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3 )
        {
            secondArr[count] = arr[i];
            count++;
        }
    }
    Array.Resize(ref secondArr, count);
    return secondArr;
}

string[] GetArray(int size)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{i}: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
}

int GetNumber(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int size = GetNumber("Enter length of array: ");
string[] originalArray = GetArray(size);
Console.Write("[" + String.Join(", ", originalArray) + "] -> ");
Console.WriteLine("[" + String.Join(", ", GetArrayWithThreeSymbols(originalArray)) + "]");
