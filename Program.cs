string[] array = { "Hello", "2", "world", ":-)" };
int maxLength = 3;

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

