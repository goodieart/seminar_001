using static System.Console;
int max = 0, num = 0;

WriteLine("Введите числа a,b,c: ");

for(int i = 0; i < 3; i++)
{
    num = int.Parse(ReadLine()!);
    if(num > max) max = num;
}

WriteLine($"max = {max}");