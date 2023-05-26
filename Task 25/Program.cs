// 25. Программа, которая находит сумму натуральных элементов в промежутке от M до N
// с помощью рекурсии.

int Sum (int M, int N) // вводим функцию Sum нахождения суммы чисел
{
    int result=M;
    if (M==N)
    return 0;
    else 
    {
        M++;
        result= M + Sum(M,N);
        return result;
    }
    
}
System.Console.WriteLine("Введите число M: ");
int M=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int N=Convert.ToInt32(Console.ReadLine());     


void SumFromMToN (int M, int N)
{
    Console.Write($"Сумма натуральных чисел от {M} до {N} равна: " + Sum(M-1,N));
}
SumFromMToN(M,N);
