﻿// Задание 2а.С.1. Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите  трёхзначное число, из которого хотите извлечь вторую цифру =>> ");
int chislo = Convert.ToInt32(Console.ReadLine());
if (chislo < 100 || chislo > 999) {Console.WriteLine("Введённое число не трёхзначное!");}
else   {int cyfra2 = (chislo/10)%10;
        Console.WriteLine($"вторая цифра в числе -> {cyfra2}");}