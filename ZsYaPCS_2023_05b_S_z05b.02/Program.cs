// Задание 05b.S.02.
 // Рекурсия
 // Сумма натуральных чисел 
 // Задача 66: Задайте значения M и N. Напишите программу, которая
 // найдёт сумму натуральных элементов в промежутке от M до N
 // с помощью рекурсии.
// !В задании не указано какими должны быть M и N, поэтому принято, что любыми целыми.      

// Ошибки до компиляции
 // не указал return во втором IF (удалил при перестройке и не написал заново)
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
                Console.WriteLine($"Между \"{argumentFrom}\" и \"{argumentTo}\" натуральных целых чисел нет!"
                                + $" Cоответственно, эта сумма равна \n{0}");
                return false;
            }
        }

        int SumNaturalNumbers(int diapazonFrom, int diapazonTo){
            if (diapazonFrom > diapazonTo){return 0;}
            if (diapazonFrom <= 0) {return SumNaturalNumbers(1, diapazonTo);}
            return SumNaturalNumbers(diapazonFrom + 1, diapazonTo)+diapazonFrom;
        }

        int sumDiapazonFromM = ReadInt("Введите число (M) от которого Вы хотите " 
                                       +$"увидеть сумму всех натуральных целых чисел : ");

        int sumDiapazonToN =   ReadInt("Введите число (N) до которого Вы хотите " 
                                       +$"увидеть сумму всех натуральных целых чисел : ");

        if (CheckingValuesForNaturalInDiapazon(sumDiapazonFromM, sumDiapazonToN)){
            Console.WriteLine("Сумма натуральных чисел в указанном диапазоне равна \n" 
                        + $"{SumNaturalNumbers(sumDiapazonFromM, sumDiapazonToN)}");

        }
    }
}
