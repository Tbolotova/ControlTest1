// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] stringArray = {"Hello", "2", "world", ":-)"};
int desiredLength = 3;
int newArrLength = GetStringNumByLength(stringArray, desiredLength);
string[] newArray = new string[newArrLength];
FillArrayByLength(stringArray, desiredLength, newArrLength);

Console.WriteLine($"The values in the array shorter than {desiredLength} symbols: {String.Join(",", stringArray)} {String.Join(",", newArray)}");