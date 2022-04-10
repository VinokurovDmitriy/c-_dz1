//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int numberA = 34;
int numberB = 27;
int numberC = 38;
int max = numberA;
if(numberB > max)
max = numberB;
if(numberC > max)
max = numberC;
Console.WriteLine($"Мааксимоальное число = {max}");