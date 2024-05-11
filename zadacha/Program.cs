// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] FirstArray = new string[5] {"abc", "3rdsa", "123d", "kgrkgje", "54f"};
string[] NewArray = new string[FirstArray.Length];

void GetNewArray(string[] FirstArray, string[] NewArray)
{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
        if(FirstArray[i].Length <= 3)
        {
            NewArray[count] = FirstArray[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
GetNewArray(FirstArray, NewArray);
PrintArray(NewArray);