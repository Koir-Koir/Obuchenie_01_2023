// Задание 04a.S.01.
// Ввод чисел
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.

// Пример идеального решения
    // добавьте сюда для сравнения со своим кодом
//

int ReadInt (string message)                //Создаём функцию, которая принимает сообщение на вывод и возвращает число;
    {Console.Write(message);                //Функция начинает выполнять действия: показывает переданное сообщение
    string value = Console.ReadLine();      //Мы объявляем временную переменную, чтобы принять ввод пользователя из консоли
    return int.Parse(value);                //Функция возвращает число, которое получает с помощью преобразования значения строки в тип инт
}

void PrintArray(int[] array){                           // Функция принимает массив, чтобы напечатать, но не возвращает ничего
    Console.Write(array[0]);                                        // Печатаем первый элемент массива, для следующего удобного форматирования на экране
    for (int i = 1; i < array.Length; i++){                         // Цикл перебора элементов массива для вывода их на экран
        Console.Write($", {array[i]}");                             // Печать элементов массива, разделённых запятой и пробелом
    }
    Console.Write(".\n\n");                                           // печать точки в конце массива и перевод курсора на новую строчку.
}

int CountingMoreZero (int[] array){
    int kolichestvo = 0;
    for (int i = 0; i < array.Length; i++){
        if (array[i] > 0){
            kolichestvo++;
        }
    }
    return kolichestvo;
}

int[] Generaciya1xMassiva(int length, string regim){    // Функция принимает длинну массива, а также диапазон случайно генерируемых целочисленных значений, присваиваемых элементам массива
    int minValue = 0, maxValue = -1;                    // установка создания гарантированного пустого массива
    int[]numbers =  new int[length];                    // создание одномерного массива длинною lenght   
    if (regim == "auto"){                               // установка диапазона для автоматического заполнения массива
        minValue = -300;
        maxValue = 300;
    }

    Random random = new Random();                                   // создание генератора случайных чисел
    for (int i = 0; i < numbers.Length; i++){                       // цикл для заполнения созданного массива случайными числами из указанного диапазона
        numbers[i] = random.Next(minValue, maxValue+1);             // непосредм\ственное заполнение каждого элемента массива
    }
    return numbers;
}

void ZapolnenieMassiva (int[] array){
    array[0] = ReadInt("Введите первое число \t\t: ");
    for (int i = 1; i < array.Length; i++){
        array[i] = ReadInt($"Введите следующее ({i+1}-е) число\t: ");
    }
    Console.WriteLine("Вы ввели все числа.\n");
}

int numbersUserEnterM = ReadInt("Сколько чисел Вы хотите ввести (не менее 5) : ");
if (numbersUserEnterM < 5) {numbersUserEnterM = 5;}
Console.Write("Введите \"auto\" для автоматического заполнения пользовательского ввода или иное, для самостоятельного ввода : ");
string regim = Console.ReadLine();

int[] userInputNumbers = Generaciya1xMassiva(numbersUserEnterM, regim);
switch (regim){
    case "auto": 
            PrintArray(userInputNumbers);
            break;
    default:
            ZapolnenieMassiva(userInputNumbers);
            break;
}

Console.WriteLine($"Вы ввели чисел больше нуля : {CountingMoreZero(userInputNumbers)}") ;