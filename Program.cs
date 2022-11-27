/* Задача: 
Написать программу, которая из имеющегося 
массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/

// "Защита от дурака" на ввод числа (размера массива)
int GetNumber(string message) {
    bool isCorrect = false;
    int result = 0;
    Console.WriteLine(message);
    while (!isCorrect) {
        isCorrect = int.TryParse(Console.ReadLine(), out result);
        if (!isCorrect)
            Console.WriteLine("\nВвели не число или оно слишком большое. Введите заново: ");
    }
    return result;
}

// Задаём размер массива
int size = GetNumber("Введите размер массива");

// Метод заполнения массива элементами через консоль
string[] GetArray(int size) {
    string[] array = new string[size];
    for (int i = 0; i < size; i++) {
        Console.WriteLine("Задайте элемент {0}:", i+1);
        array[i] = Console.ReadLine();
    }
    return array;
}

// Задаём исходный массив
string[] array = GetArray(size);

// Метод вывода массива в консоль
void PrintArray(string[] array) {
    Console.WriteLine("\nПолучили массив строк:\n");
    Console.WriteLine("[{0}]", string.Join("; ", array));
}

// Вывод исходного массива
PrintArray(array);

// Метод для составления трёхсимвольного массива из исходного
string[] GetThreeCharArray(string[] array) {
    string[] resultArray = array.Where(x => x.Length <= 3).ToArray();
    return resultArray;
}
// Или с помощью циклов алгоритм можно записать так:

// string[] GetThreeCharArray(string[] array) {
// Считаем сколько трёхсимвольных (или меньше) элементов в исходном массиве
//     int count = 0;
//     for (int i = 0; i < size; i++) {
//         if (array[i].Length <= 3)
//             count++;
//     }
// Задаём длину нового массива
//     string[] resultArray = new string[count];
// Задаём переменную, которая будет запоминать позицию в исходном массиве
//     int position = 0;
// Пробегаем по исходному массиву, при нахождении нужного элемента, записываем его в новый
//     for (int j = 0; j < count; j++) {
//         for (int k = position; k < size; k++) {
//             position++;
//             if (array[k].Length <=3) {
//                 resultArray[j] = array[k];
//                 break;
//             }
//         }
//     }
//     return resultArray;
// }

// Получаем итоговый массив
string[] resultArray = GetThreeCharArray(array);

// Вывод результата
Console.Write("\nОставляем строки с 3-мя символами.");
PrintArray(resultArray);