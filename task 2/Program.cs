// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите два целых числа");
int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
if(A > B) /*A - наибольшее*/
    Console.WriteLine("Max " + A + "; Min " + B );
    else /*B - наибольшее*/
    Console.WriteLine("Max " + B + "; Min " + A );
