// Задание 2а.С.2. Задача 13: Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, что третьей цифры нет

Console.Write("Введите число, из которого хотите извлечь третью с начала цифру -> ");
int chislo = Convert.ToInt32(Console.ReadLine());
int cyfra3;
if (chislo < 0) {chislo = -chislo;}
if (chislo < 100) {Console.Write("У введённого числа нет третьей цифры...");}
    else {while (chislo > 999) {chislo = chislo/10;}
    cyfra3 = chislo%10;
    Console.Write(cyfra3);}