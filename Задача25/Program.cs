//Напишите цикл, который принимает на вход два числа (A и B) и
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//Ограничения:
//- Нельзя использовать класс Math
//- Должна быть отдельная функция Power, которая возвразает результат
//- Внутри функций НЕЛЬЗЯ использовать класс Console. Только в основном
// блоке кода

Console.Clear();
Console.Write("Введите число А ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число B ");
int b = int.Parse(Console.ReadLine());
int pow = 1;
int count = 1;

int Power (int a)
{
    while (count <= b)
    {
        pow = pow * a;
        count++;
    }
    return pow;
}

Console.Write(Power(a));