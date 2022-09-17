using static System.Console;

WriteLine("Введите числа a,b: ");
int max = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);

if(b > max) max = b;

WriteLine(max);