/*  : Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
 Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться
  коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
["1234", "1567", "-2", "computer science"] → ["-2"]
["Russia", "Denmark", "Kazan"] → []*/

using System.Xml.XPath;

string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};


string[] GetNewArray(string[] stringArray)
{
  int newSize = 0;
  foreach (var item in stringArray)
  {
    if (item.Length <= 3)
        {
            newSize ++;
        }
  }
  string[] result = new string[newSize];
  int i = 0;
  foreach (var item in stringArray)
  {
    if (item.Length <= 3)
        {
            result[i] = item;
            i ++;
        }
  }
  return result;
}
void PrintStringArray(string [] stringArray, string[] stringArrayNew)
{
    Console.Write($"[{String.Join(", ", stringArray)}] -> ");
    Console.WriteLine($"[{String.Join(", ", stringArrayNew)}]");
}
PrintStringArray(array1, GetNewArray(array1));
PrintStringArray(array2, GetNewArray(array2));
PrintStringArray(array3, GetNewArray(array3));