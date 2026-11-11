Console.WriteLine("TABUADA");

int num;

Console.Write("Digite um número para ver a tabuada: ");
num = int.Parse(Console.ReadLine());

for (int i = 0; i<=10; i++)
{
    Console.WriteLine($"{num} x {i} = {num * i}");
}


