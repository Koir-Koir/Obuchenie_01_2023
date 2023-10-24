// Задание 03a.S.01. Задача 25: Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную степень B.

int ReadInt (string message)                //Создаём функцию, которая принимает сообщение на вывод и возвращает число;
    {Console.Write(message);                //Функция начинает выполнять действия: показывает переданное сообщение
    string value = Console.ReadLine();      //Мы объявляем временную переменную, чтобы принять ввод пользователя из консоли
    return int.Parse(value);                //Функция возвращает число, которое получает с помощью преобразования значения строки в тип инт
}

int StepenChisla (int A, int B){
    int result = 1;
    for (int i = 1; i<= B; i++){
        result *= A;
    }
    return result;
}

int osnovanie = ReadInt ("Для получения числа в степени, ведите : \tоснование A = ");
int stepen    = ReadInt (                              "\t\t\t\t\t  степень B = ");

if (stepen >= 0) {Console.WriteLine($"\t\t\t\t\t  результат = {StepenChisla(osnovanie, stepen)}.");}
else {Console.WriteLine($"К сожалению, эта программа не может посчитать степень {stepen} - у неё лапки :\'(");}