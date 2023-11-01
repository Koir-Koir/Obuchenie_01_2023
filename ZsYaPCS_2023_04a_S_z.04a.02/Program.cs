// Задание 04a.S.02.
// Точка пересечения
// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// Пример идеального решения
    // добавьте, мистерь великий программаторь, его сюда для сравнения со своим кодом
//

//Функция ввода
int ReadInt (string message)                //Создаём функцию, которая принимает сообщение на вывод и возвращает число;
    {Console.Write(message);                //Функция начинает выполнять действия: показывает переданное сообщение
    string value = Console.ReadLine();      //Мы объявляем временную переменную, чтобы принять ввод пользователя из консоли
    return int.Parse(value);                //Функция возвращает число, которое получает с помощью преобразования значения строки в тип инт
}

// Функция ввода коэфициентов
void UserInputCoefficient (double[] arrayK, double[] arrayB){
    string[] masMessage = {
     "Введите коэфициенты уравнения \"Y = k1 * X + b1\" для первой прямой:\nкоэфициент \"k1\" при X : ",
     "Введите коэфициенты уравнения \"Y = k2 * X + b2\" для второй прямой:\nкоэфициент \"k2\" при X : ",
     "коэфициент \"b1\" : ",
    "коэфициент \"b2\" : "};
    
    for (int i = 0; i < 2; i++){
        arrayK[i] = ReadInt(masMessage[i]);
        arrayB[i] = ReadInt(masMessage[i+2]);
    }
}

// Функция сложных расчётов
double[] PeresechenieDvukhPryamykh(double[] arrayK, double[] arrayB){
    double[] peresechenie = {0, 0};
    peresechenie[0] = (arrayB[1] - arrayB[0]) / (arrayK[0] - arrayK[1]);
    peresechenie[1] = arrayK[0] * peresechenie[0] + arrayB[0];
    return peresechenie;
}

double[] massivK = new double[] {0, 0};
double[] massivB = new double[] {0, 0};
double[] tochkaPeresecheniya = new double[] {0, 0};
UserInputCoefficient(massivK, massivB);


tochkaPeresecheniya = PeresechenieDvukhPryamykh(massivK, massivB);
Console.WriteLine($"\nТочка пересечения двух прямых : ({tochkaPeresecheniya[0]:f2}; {tochkaPeresecheniya[1]:f2}).");