Console.WriteLine("Núneros Primos");

int num, cont = 0;

Console.Write("Entre com um número: ");
num = int.Parse(Console.ReadLine());

for (int i = 2; i <= num; i++)
{
    cont = 0;
    for (int j = i; j >= 2; j--) 
    {
        if (i % j == 0)
        {
            cont++;
        }
        if (cont > 1)
        {
            break;
        }
    }

    if (cont <= 1)
    {
        Console.WriteLine(i);

    }
}


