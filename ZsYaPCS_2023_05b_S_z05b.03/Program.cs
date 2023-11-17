// Задание 05b.S.03.
 // Рекурсия
 // Функция ака Акермана
 // Напишите программу вычисления функции Аккермана с помощью 
 // рекурсии. Даны два неотрицательных числа m и n.
// 

// Ошибки до компиляции
 // не все пути к коду возвращают значение. : 
 //     /*else if (argumentM > 0 && argumentN > 0)*/ => else
 // > 0 => >= 0
//

using System;

class Program{
    static public void Main(string[] args){

        int ReadInt (string message){
            Console.Write(message);                
            string value = Console.ReadLine();      
            return int.Parse(value);                
        }

        bool CheckingValuesForAkerman(int argumentM, int argumentN){
            if (argumentM >= 0 && argumentN >= 0){
                return true;
            } else {
                Console.WriteLine("Функция Акермана можно посчитать если и M,"
                                + " и N будут неотрицательными.");
                return false;
            }
        }

        int AkermanFunction(int argumentM, int argumentN){
            if (argumentM == 0){    /* argumentM == 0 && argumentN > 0: запутался с определениями*/
                return argumentN + 1;

            } else if (argumentM > 0 && argumentN == 0){
                return AkermanFunction(argumentM - 1, 1);

            } else {        /*else if (argumentM > 0 && argumentN > 0) как бы запутался*/
                return AkermanFunction(argumentM - 1, AkermanFunction(argumentM, argumentN - 1));
            }
        }

        int numberM = ReadInt("Для вычисления функции Акермана A(M, N) " 
                            + "введите неотрицательное число \"M\" : ");

        int numberN = ReadInt("Для вычисления функции Акермана A(M, N) " 
                            + "введите неотрицательное число \"N\" : ");

        if (CheckingValuesForAkerman(numberM, numberN)){
            Console.WriteLine("Функция Акермана равна \n" 
                        + $"{AkermanFunction(numberM, numberN)}");
        }
    }
}