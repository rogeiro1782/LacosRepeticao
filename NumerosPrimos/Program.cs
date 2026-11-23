bool Primo(int num)
{
    if (num <= 2)
        return false;          

    for (int i = 2; i < num; i ++)
    {
        if (num % i == 0)
            return false;
    }
    return true;
}

Console.Write("Digite um número: ");
int num = int.Parse(Console.ReadLine());

if (Primo(num))
{
    Console.WriteLine("É número primo.");
}
else
{
    Console.WriteLine("Não é número primo.");
}
for (int i = 2; i <= num; i++)
{
    if (Primo(i))
    {
        Console.WriteLine(i);
    }
}
 
