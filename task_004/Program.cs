using static System.Console;

WriteLine("Введите числа a,b,c: ");
int max = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int c = int.Parse(ReadLine()!);

if(b > max) max = b;
if(c > max) max = c;

WriteLine($"max = {max}");