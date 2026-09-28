// 1. Kalkulyator
Console.Write("Birinchi son: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Operatsiya (+, -, *, /): ");
string op = Console.ReadLine()!;

Console.Write("Ikkinchi son: ");
int b = int.Parse(Console.ReadLine()!);

switch (op)
{
    case "+":
        Console.WriteLine(a + b);
        break;
    case "-":
        Console.WriteLine(a - b);
        break;
    case "*":
        Console.WriteLine(a * b);
        break;
    case "/":
        Console.WriteLine(a / b);
        break;
}

// 2. 1 dan N gacha yig'indi
Console.Write("N: ");
int n = int.Parse(Console.ReadLine()!);

int sum = 0;
for (int i = 1; i <= n; i++)
{
    sum += i;
}
Console.WriteLine(sum);
