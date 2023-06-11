// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("введите число:");
int numberA = Convert.ToInt32(Console.ReadLine()); 
int count;

Console.Clear();

Console.WriteLine("число: " + numberA);

count = numberA % 2;

if (count == 0){
    Console.WriteLine("число " + numberA + " чётное");
}
else{
    Console.WriteLine("число " + numberA + " не чётное");
}

