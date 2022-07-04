// программа,которая из имеющегося массива строк формирует массив из строк,длина которых меньше или = 3 символам
// первоначаьно можно массив ввести с клавиатуры либо задать на старте выполнения алгоритма.

// инициализируем массив 1, обьялем массив 2
string[] Arr1 = new string[7] {"abc", "13", "geek", "brains", "2022","134","ok" };
string[] Arr2 = new string[Arr1.Length];

// метод ,выбирющий соответсвенно условию задчи строки в массив 2
void SelectionArr2(string[] Arr1, string[] Arr2)
{
    int count = 0;
    for (int i = 0; i < Arr1.Length; i++)
    {
    if(Arr1[i].Length <= 3)
        {
        Arr2[count] = Arr1[i];
        count++;
        }
    }
}
SelectionArr2(Arr1, Arr2);

// метод вывода массивов 
void PrintArray(string[] array)
{
    Console.Write("{");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
        if (i< array.Length-1)
        Console.Write(" , ");
    }
    Console.WriteLine(" }");
}
PrintArray(Arr1);
PrintArray(Arr2);

