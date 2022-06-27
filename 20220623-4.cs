//Escrever um algoritmo que indique se um número digitado está compreendido entre 20 e 90 ou não.

int num;

Console.WriteLine("Insira um número qualquer: ");
num = Convert.ToInt32(Console.ReadLine());

if (num > 20 && num < 90)
{
    Console.WriteLine("O número digitado está compreendido entre 20 e 90.");
}
else 
{
    Console.WriteLine("O número digitado não está compreendido entre 20 e 90.");
}