//Напишите программу, которая принимает на вход число и выдаёт сумму
//цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
//Ограничения:
//- Должна быть отдельная функция, которая возвразает результат суммы
//цифр
//- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном
//блоке кода

Console.Clear();
Console.Write("Введите число ");
int a = Math.Abs(int.Parse(Console.ReadLine()));
int ten = 0;
int division = a;

while (division <= a)
{
    division = division / 10;
    ten++;
    if (division == 0)
    break; 
    
}

int[] array = new int[ten];

void FillArray(int[] array)
{
    int num = 0;
    int pow = 1;
    int pow1 = ten - 1;
    for (int i = 0; i < array.Length; i++)
    {
        num = (a % Convert.ToInt32(Math.Pow(10, pow)))
        / Convert.ToInt32(Math.Pow(10, i));
        pow++;
        array[ten - 1] = num;
        ten--;
    }
    
}

int Summ (int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        summ = summ + array[i];
    }
    return summ;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i == array.Length - 1)
        Console.Write("]");
        else
        Console.Write(", ");
    }
}

FillArray(array);
Console.Write($" {Summ(array)}");
