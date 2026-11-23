Console.WriteLine("Fatorial");

int num;
Console.WriteLine("Entre com um número: ");
num = int.Parse(Console.ReadLine());

int fatorial = 1;

Console.Write($"{num}! = ");

for (int i = num; i >= 1; i--)
{
    fatorial = fatorial * i;
    Console.Write(i);

    if(i > 1)
    {
        Console.Write(" x ");
    }
    
}
Console.Write($" = {fatorial}");

