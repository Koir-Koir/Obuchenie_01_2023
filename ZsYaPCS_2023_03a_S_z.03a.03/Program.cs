// Задание 03a.S.03. Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.

void ZapolnenieMassiva (int[] mass, int otz, int doz){
    int len = mass.Length;
    for (int i = 0; i < len; i++){
        mass[i] = new Random().Next(otz, doz+1);
    }
}

void PrintMassiv (int[] mass){
    int len = mass.Length;
    Console.Write (mass[0]);
    for (int i = 1; i < len; i++){
        Console.Write ($"  {mass[i]}");
    }
    Console.WriteLine("");
}


int ReadInt (string message)                //Создаём функцию, которая принимает сообщение на вывод и возвращает число;
    {Console.Write(message);                //Функция начинает выполнять действия: показывает переданное сообщение
    string value = Console.ReadLine();      //Мы объявляем временную переменную, чтобы принять ввод пользователя из консоли
    return int.Parse(value);                //Функция возвращает число, которое получает с помощью преобразования значения строки в тип инт
}

int length = ReadInt ("Введите требуемую длинну массива, для заполнения его случайными числами : ");
int otZ = ReadInt    ("Введите  нижнюю границу диапазона значений : ");
int doZ = ReadInt    ("Введите верхнюю границу диапазона значений : ");

if (length > 0){
int[] massiv = new int[length];
ZapolnenieMassiva (massiv, otZ, doZ);
PrintMassiv (massiv);
}
else {Console.WriteLine("Мы в подпространство не создаём массив, обратись в будущее (ориентировочно через 10 000 лет), \nили введи целое число элементов в массиве больше 0");}