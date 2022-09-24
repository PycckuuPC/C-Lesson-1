// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три целых числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C = Convert.ToInt32(Console.ReadLine());

if(A > B)
    if(A > C)   /*A - наибольшее*/
    Console.WriteLine(A + " большее число");
    else /*С - наибольшее*/
    Console.WriteLine(C + " большее число");
else
    if(B > C)   /*B - наибольшее*/
    Console.WriteLine(B + " большее число");
    else /*С - наибольшее*/
    Console.WriteLine(C + " большее число");