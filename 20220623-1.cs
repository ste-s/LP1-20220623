//Ler um número e informar se ele é divisível por 3 e por 7.

int num;

Console.WriteLine("Insira um número qualquer: ");
num = Convert.ToInt32(Console.ReadLine());

if ((0 == (num % 3)) && (0 == (num % 7)))
{
    Console.WriteLine(num + " é divisível por 3 e 7.");
}
else
{
    if ((0 != (num % 3)) && (0 == (num % 7)))
    {
        Console.WriteLine(num + " é divisível por 7 mas não é por 3.");
    }
    else
    {
        if ((0 == (num % 3)) && (0 != (num % 7)))
        {
            Console.WriteLine(num + " é divisível por 3 mas não é por 7.");
        }
        else 
        {
            Console.WriteLine(num + "  não é divisível por 3 nem por 7");        
        }
    }

}
