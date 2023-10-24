﻿// Задание 03a.S.02. Задача 27: Напишите программу, которая принимает на вход 
// число и выдаёт сумму цифр в числе.

int ReadInt (string message)                //Создаём функцию, которая принимает сообщение на вывод и возвращает число;
    {Console.Write(message);                //Функция начинает выполнять действия: показывает переданное сообщение
    string value = Console.ReadLine();      //Мы объявляем временную переменную, чтобы принять ввод пользователя из консоли
    return int.Parse(value);                //Функция возвращает число, которое получает с помощью преобразования значения строки в тип инт
}

int SummaCifr (int n){
    int summaCifr = 0;
    while (n > 0)
        {summaCifr += n % 10;
        n = n / 10;
    } 
    return summaCifr;
}

int N = ReadInt ("Для подсчёта суммы цифр в числе, введите это число : ");
        if (N < 0) {N = -N;};
Console.WriteLine(SummaCifr (N));