using static System.Console;
int it = 2;
int endian = 1;

Write("Введите N: ");
int n = int.Parse(ReadLine()!);
Write("Чётные числа в интервале ");

if(n < 1)                                       // Здесь и далее код усложнен, чтобы избежать накладных расходов в виде (i % 2) в цикле;
{
    it = -2;                                    // Реализуем обратный проход цикла, если n < 1;
    Write($"[{n},1]: ");
}
else
{
    Write($"[1,{n}]: ");
}

if(n % 2 == 0) endian = 2;
if(it < 0) endian *= -1;                        // Здесь можно использовать Math.Sign;

if(n < 1) Write("0,"); 

for(int i = it; i != n + endian; i += it)       // Можно и while, но for лаконичнее;
{
    Write($"{i},");
}

Write("\b ");                                   // Экранируем BS, чтобы удалить последнюю запятую;


