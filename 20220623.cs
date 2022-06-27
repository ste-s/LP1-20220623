//Ler um número e informar se ele é divisível por 3 e por 7.

int num;

Console.WriteLine("Insira um número qualquer: ");
num = Convert.ToInt32(Console.ReadLine());

if ((0 == (num % 3)) && (0 == (num % 7)))
{
    Console.WriteLine(num + " é divisível por 3 e 7");
}