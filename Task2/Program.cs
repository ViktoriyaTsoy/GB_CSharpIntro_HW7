// Функция Аккермана
int ReadInt(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// Функция Аккермана

int A(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }

    if (n == 0)
    {
        return A(m - 1, 1);
    }
    else
    {
        return A(m - 1, A(m, (n - 1)));

    }

}

int N = ReadInt("Enter N");
int M = ReadInt("Enter M");
Console.WriteLine(A(M,N));