 
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("введите числа:");
int numberA = Convert.ToInt32(Console.ReadLine()),
    numberB = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int max = numberB, min = numberA;

Console.WriteLine("numberA = " + numberA + " , " + "numberB = " + numberB);

if (numberA > numberB){
    max = numberA;
    min = numberB;
}

Console.Write("max = " + max + " , " + "min = " + min);
