Console.WriteLine("Sequência Fibonacci");

Console.Write("Digite um número final ara sequência fibonacci: ");
int num = int.Parse(Console.ReadLine());

int ant = 0;
int atual = 1;

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(ant + " ");
    int seq = ant + atual;
    ant = atual;
    atual = seq;
}
