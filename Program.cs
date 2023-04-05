string[] a = {"Hello", "2", "world", ":-)"};


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

System.Console.WriteLine(SumQualifiedElements(a));