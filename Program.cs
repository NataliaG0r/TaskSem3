// Урок 3. Базовые алгоритмы. Продолжение
// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

System.Console.WriteLine("введите пятизначное число");
string str = Console.ReadLine();

System.Console.WriteLine(str);

char[] c = str.ToCharArray();

if (str.Length == 5)
{
    if ((c[0] == c[4]) && (c[1] == c[3]))
    {
        System.Console.WriteLine($"число {str} является палиндромом");
    }

    else System.Console.WriteLine($"число {str} не является палиндромом");
}

else System.Console.WriteLine($"число {str} не пятизначное  ");

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


int InputNumber(string coOrd)
{
    System.Console.WriteLine(coOrd);
    return Convert.ToInt32(Console.ReadLine());

}

int x1 = InputNumber("Введите координату x первой точки: ");
int y1 = InputNumber("Введите координату y первой точки: ");
int z1 = InputNumber("Введите координату z первой точки: ");

int x2 = InputNumber("Введите координату x второй точки: ");
int y2 = InputNumber("Введите координату y второй точки: ");
int z2 = InputNumber("Введите координату z второй точки: ");

double result = Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)), 2);

System.Console.WriteLine($"Расстояние = {result}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125