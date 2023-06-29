//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if (A < B)
{
    Console.WriteLine(B);
}
else
{
    Console.WriteLine(A);
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

int C = Convert.ToInt32(Console.ReadLine());
int D = Convert.ToInt32(Console.ReadLine());
int E = Convert.ToInt32(Console.ReadLine());
int max = 0;
if ( C >= E && E >= D)
{
    max = C;
}
else if ( D >= E && D >= C )
{
    max = D;
}
else
{
    max = E;
}
Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

int M = Convert.ToInt32(Console.ReadLine());
if  (M % 2 == 0)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


int N = Convert.ToInt32(Console.ReadLine());
int number = 1;
while (number <= N)
{
    Console.WriteLine(number);
    number++;
}