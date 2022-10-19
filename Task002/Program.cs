//Задача: Написать программу,
//которая из сформированного массива строк содержащих символы и числа
//создать массив из строк,
//в который попадут только символы, не являющиеця цифрами.

Console.Clear();
int InputSize(string txt)
{
    Console.Write($"Введите количество {txt}: ");
    int size = 1;
    while ((!int.TryParse(Console.ReadLine(), out size)) || size <= 0)
    {
        Console.Write($"Введите количество {txt}: ");
    }
    return size;
}

int elem = InputSize("элементов");
string[] arr = new string[elem];
string[] numbersArr = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };

void FillArr(string[] arr)
{
    for (int i = 0; i < elem; i++)
    {
        Console.Write($"Введите строку под индексом ({i}): ");
        arr[i] = Console.ReadLine();

    }
}
void PrintArr(string[] arr)
{
    for (int i = 0; i < elem; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

void NewArr(string[] arr, string[] numbersArr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < numbersArr.Length; j++)
        {
            if (arr[i].Contains(numbersArr[j]))
            {
                arr[i] = arr[i].Replace(numbersArr[j], "");
            }
        }   
    }
}


FillArr(arr);
Console.WriteLine("Исходный массив: ");
PrintArr(arr);
NewArr(arr, numbersArr);
Console.WriteLine("Новый массив: ");
PrintArr(arr);