// 26. Программа, которая вычисляет функции Акермана с помощью рекурсии.
// Даны два неотрицательных числа M и N.

//Функция Аккермана выглядит так:

//A (M,N) = N+1, если M=0;
//          A(M-1,1), если M!=0, N=0;
//          A(M-1,A(M,N-1)), если M>0, N>0.
// Так, для M=2, N=3 --> A (2,3)=9;
//   , а если M =3, N=2 --> A (3,2)=29;      


int Aker(int M, int N)
{
    if (M == 0)
        return N + 1;
    else if (N == 0)
    {
        return Aker(M - 1, 1);
    }
    else
    {
        return Aker(M - 1, Aker(M, N - 1));
    }
}
System.Console.WriteLine("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());


void Result(int M, int N)
{
    Console.Write($"Результат вычисления функции Аккермана для неотрицательных чисел {M} и {N} равен: " + Aker(M, N));
}
Result(M, N);
