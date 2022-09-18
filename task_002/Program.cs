using static System.Console;

WriteLine("Введите числа a,b: ");
int a = int.Parse(ReadLine()!);         // Стараемся не использовать дополнительные переменные
int b = int.Parse(ReadLine()!);         // (экономим память);

if(b > a)
{
    a = a + b;                          // Здесь используем "арифметический" swap;
    b = a - b;                          // Возможная проблема в продакшене: stack overflow
    a = a - b;                          // (при значениях переменных, близких к пределам размерности типа);
}

WriteLine($"max = {a}; min = {b}");