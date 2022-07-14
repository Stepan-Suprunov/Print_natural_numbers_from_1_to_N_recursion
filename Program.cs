// Вывести все натуральные числа от 1 до N


void Print(int a)
{
    if (a == 0)
    {
        return;
    }
    Print(a-1);
    Console.Write(a + " ");
}

int N = 5;
Print(N);