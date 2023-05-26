// 24. Программа, которая выведет все натуральные числа в промежутке от N до 1 с помощью рекурсии.

void Numbers (int startNum, int endNum)
{
    if (startNum==endNum-1)
    return;
    Console.Write($"{startNum} ");
    startNum--;
    Numbers(startNum,endNum);
}
int N=8;     
int M=1;
Numbers(N,M);