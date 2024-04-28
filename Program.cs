string[] array = { "Hello", "2", "world", ":-)" };
int maxLength = 3;
PrintArray(array);
PrintArray(CreateNewArray(array, CountNewArray(array)));

int CountNewArray(string[] array)
{
    int countNewArray = 0;
    for (int i = 0;i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            countNewArray++;
        }
    }

    return countNewArray;
}

string[] CreateNewArray(string[] array, int count)
{
    string[] newArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= maxLength)
        {
            newArray[j] = array[i];
            j++;
        }
    }

    return newArray;
}

void PrintArray(string[] array)
{   
    System.Console.Write("[");
    for (int i = 0;i < array.Length-1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine($"{array[array.Length-1]}]");
}