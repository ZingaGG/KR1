string[] a = {"Hello", "2", "world", ":-)"};

int ArrayLength = SumQualifiedElements(a);

string[] ResultArray = ArrayEdit(a, ArrayLength);

PrintStringArray(ResultArray);

int SumQualifiedElements(string[] a)
{
    int result = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if(a[i].Length <= 3)
        {
            result++;
        }
    }
    return result;
}

string[] ArrayEdit(string[] a, int ArrayLength)
{
    string[] result = new string[ArrayLength];
    int index = 0;
    for (int i = 0; i < result.Length; i++)
    {
        for (int j = index; j < a.Length; j++)
        {
            if(a[j].Length <= 3)
            {
                result[i] = a[j];
                index = j+1;
                break;
            }
        }
        
    }

    return result;
}

void PrintStringArray(string[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.WriteLine($"Array[{i}] = {a[i]}");   
    }
}

