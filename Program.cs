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

int size = GetNumber("Введите размер массива");

string[] GetArray(int size) {
    string[] array = new string[size];
    for (int i = 0; i < size; i++) {
        Console.WriteLine("Задайте элемент {0}:", i+1);
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] array = GetArray(size);

void PrintArray(string[] array) {
    Console.WriteLine("\nПолучили массив строк:\n");
    Console.WriteLine("[{0}]", string.Join("; ", array));
}

PrintArray(array);

string[] GetThreeCharArray(string[] array) {
    string[] resultArray = array.Where(x => x.Length <= 3).ToArray();
    return resultArray;
}

Console.Write("Оставляем строки с 3-мя символами.");
PrintArray(
    GetThreeCharArray(array)
);