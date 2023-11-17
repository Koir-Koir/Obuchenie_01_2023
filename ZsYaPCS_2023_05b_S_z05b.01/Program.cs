// Задание 05b.S.01.
 // Рекурсия
 // Вывод чисел 
 // Задача 64: Задайте значения M и N. Напишите программу, которая
 // выведет все чётные натуральные числа в промежутке от M до N
 // с помощью рекурсии.
// !В задании не указано какими должны быть M и N, поэтому принято, что любыми целыми.      

// Ошибки до компиляции
 // не убрал при копировании int
 // не указал void рекурсивной функции
 // 
//

using System;

class Program{
    static public void Main(string[] args){

        int ReadInt (string message){
            Console.Write(message);                
            string value = Console.ReadLine();      
            return int.Parse(value);                
        }

        bool CheckingValuesForNaturalInDiapazon(int argumentFrom, int argumentTo){
            if (argumentTo > 0 && argumentTo >= argumentFrom){
                return true;
            } else if (argumentTo < argumentFrom){
                Console.WriteLine("Вы ввели некорректный диапазон! Введите вначале меньшее число, а затем большее.");
                return false;
            } else {
                Console.WriteLine($"Между \"{argumentFrom}\" и \"{argumentTo}\" натуральных целых чисел нет!");
                return false;
            }
        }

        void PrintNaturalNumbers(int diapazonFrom, int diapazonTo){
            if (diapazonFrom > diapazonTo){return;}
            if (diapazonFrom > 0) {Console.Write($"{diapazonFrom}\t");}
            PrintNaturalNumbers(diapazonFrom + 1, diapazonTo);
        }

        int printDiapazonFromM = ReadInt("Введите число (M) от которого Вы хотите " 
                                       +$"увидеть все натуральные числа : ");
        int printDiapazonToN =   ReadInt("Введите число (N) до которого Вы хотите " 
                                    +$"увидеть все натуральные целые числа : ");

        if (CheckingValuesForNaturalInDiapazon(printDiapazonFromM, printDiapazonToN)){
            PrintNaturalNumbers(printDiapazonFromM, printDiapazonToN);
        }
    }
}