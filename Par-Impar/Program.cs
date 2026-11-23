Console.WriteLine("Par e Impar");

int num;

Console.Write("Digite um Número: ");
num = int.Parse(Console.ReadLine());


    for (int i = 1; i <= num; i++)
    {
        if (i % 2 != 0)
        {
            Console.WriteLine(i);
        }
    }
    Console.WriteLine();

    for (int i = num; i >= 1; i--)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);
        }

    }