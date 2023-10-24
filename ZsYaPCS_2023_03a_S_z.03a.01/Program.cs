// Задание 03a.S.01. Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.

int ReadInt (string message)                //Создаём функцию, которая принимает сообщение на вывод и возвращает число;
    {Console.Write(message);                //Функция начинает выполнять действия: показывает переданное сообщение
    string value = Console.ReadLine();      //Мы объявляем временную переменную, чтобы принять ввод пользователя из консоли
    return int.Parse(value);                //Функция возвращает число, которое получает с помощью преобразования значения строки в тип инт
}

double StepenChisla (double A, int B){
    double result = 1;      int b = B;
    if (B < 0) {B = -B;}
    for (int i = 1; i<= B; i++){
        result *= A;
    }
    if (b < 0) {result = 1/result;}
    return result;
}

double osnovanie = ReadInt ("Для получения числа в степени, ведите : \tоснование A = ");
int stepen    = ReadInt (                              "\t\t\t\t\t\t  степень B = ");

Console.WriteLine($"\t\t\t\t\t Получите результат = {StepenChisla(osnovanie, stepen)}.");
//else {Console.WriteLine($"К сожалению, эта программа не может посчитать степень {stepen} - у неё лапки :\'(");}