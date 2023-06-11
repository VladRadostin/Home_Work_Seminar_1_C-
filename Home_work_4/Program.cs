// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("введите число:");
int numberA = Math.Abs(Convert.ToInt32(Console.ReadLine())); 
int count = 2;

Console.Clear();

Console.WriteLine("число: " + numberA);


Console.Write("чётные числа: ");
while (count <= numberA){
    Console.Write($"{count}, ");
    count = count + 2;
}