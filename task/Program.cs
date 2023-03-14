/* Hаписать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать 
на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры
["hello", "2", "world", ":-)"] -> ["2", ":-")]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> [ ] */

string[] GetStringArray(string message) // Ввод масива строк
{
    Console.WriteLine(message);
    string ArrayElements = Console.ReadLine();
    int len = ArrayElements.Length;
    string resArrayElemet = String.Empty;
    for (int i = 0; i < len; i++)
    {
        if (ArrayElements[i] == ' ')
        {
        }
        else
        {
            resArrayElemet = resArrayElemet + $"{ArrayElements[i]}";
        }
    }
    string[] stringArray = resArrayElemet.Split(',');
    return stringArray;
}

void PrintStringArray(string[] stringArray) // Печать введенного масива
{

    if (stringArray.Length > 0)
    {
        Console.Write("[");
    for (int i = 0; i < stringArray.Length - 1; i++)
    {
               Console.Write($"{stringArray[i]}, ");
    }
    Console.Write($"{stringArray[stringArray.Length - 1]}");
    Console.WriteLine("]");
    }
    else
    {
      Console.WriteLine("[]");  
    }
}

int GetTheNumberOfElements(string[] stringArray) // определение размера нового масива
{
    int count = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


string[] GetNewArray(int count, string[] array) // Получение нового массива
{
    string[] newArray = new string[count];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[index] = array[i];
            index++;
        }
    }
    return newArray;
}

string[] stringAr = GetStringArray("Введите массив строк, разделяя элементы запятой: ");
Console.WriteLine($"В веденоом массиве {stringAr.Length} элементов:");
PrintStringArray(stringAr);
int count = GetTheNumberOfElements(stringAr);
string[] resultStringArray = GetNewArray(count, stringAr);
Console.WriteLine($"В полученном массиве {resultStringArray.Length} элементов:");
PrintStringArray(resultStringArray);

