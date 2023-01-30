// Задача: Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на 
// старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// Примеры:
// ["hello","2","world",":-)"]->["2",":-)"]
// ["1234","1567","-2","computer science"]->["-2"]
// ["Russia","Denmark","Kazan"]->[]

string [] CreateArray(int size) // создаем массив строк
{
    string [] array = new string [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i+1} элемента массива:");
        array[i] = Console.ReadLine();
    }
    Console.Write("["+string.Join(" ", array)+"]");
    return array;
}

int CountSigns (string a) // считаем количество знаков элемента
{
    int count = a.Length;
    return count;
}

int CountElemArrLenghtLessThen3 (string [] inArray) // считаем количество элементов
{                                                   // массива с длиной <=3
    int count = 0;
    for (int i=0; i<inArray.Length;i++)
    {
        if (CountSigns(inArray[i])<=3) count++;
        else count=count;
    }
    return count;
}

string [] NewArray(string [] inArray) // формируем массив с длиной элементов <=3
{
    string [] newarr = new string [CountElemArrLenghtLessThen3 (inArray)];
    int j = 0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (CountSigns(inArray[i])<=3) 
        {
            newarr[j] = inArray[i];
            j++;
        }
    }
    return newarr;
}

Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine());
while (n<1) 
{
    Console.WriteLine ("!Ошибка, введите положительное число n");
    Console.WriteLine("Введите число n: ");
    n = int.Parse(Console.ReadLine());
}
string [] originArray = CreateArray(n);
Console.Write("-> ["+string.Join(" ", NewArray(originArray))+"]");