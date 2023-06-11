
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("введите числа:");

int numberA = Convert.ToInt32(Console.ReadLine()), 
    numberB = Convert.ToInt32(Console.ReadLine()), 
    numberC = Convert.ToInt32(Console.ReadLine());

Console.Clear();

Console.WriteLine("numberA = " + numberA + " , " + "numberB = " + numberB + " , " + "numberC = " + numberC);

int max = numberA;


if (max < numberB && numberB > numberC){
    max = numberB;
}

if (max < numberC && numberC > numberB){
    max = numberC;
}

Console.WriteLine("max = " + max);
