// 25. Программа, которая находит сумму натуральных элементов в промежутке от M до N
// с помощью рекурсии.

void Sum (int M, int N)
{
    int result=M;
    if (M==N)
    return 0;
    else 
    {
        M++;
        result=M+Sum(M,N);
        return result;
    }
    Console.Write($"{result} ");
    Sum(M,N);
}
int N=8;     
int M=1;
Sum(M,N);
