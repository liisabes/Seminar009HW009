//Основные пункты решения задачи

//1)Функция для корректного ввода размера массива

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

//2)Функция заполнения массива вручную

void FillArr(string[] arr)
{
    for (int i = 0; i < elem; i++)
    {
        Console.Write($"Введите строку под индексом ({i}): ");
        arr[i] = Console.ReadLine();

    }
}

//3)Функция печати массива

void PrintArr(string[] arr)
{
    for (int i = 0; i < elem; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

//4)Функция вычисления нового массива

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
