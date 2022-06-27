//A prefeitura do Rio de Janeiro abriu uma linha de crédito para os funcionários estatutários. 
//O valor máximo da prestação não poderá ultrapassar 30% do salário bruto. Fazer um 
//algoritmo que permita entrar com o salário bruto e o valor da prestação e informar se o 
//empréstimo pode ou não ser concedido.

double salario, prestacao;

Console.WriteLine("Insira o valor bruto de seu salário: ");
salario = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Insira o valor cheio da prestação: ");
prestacao = Convert.ToDouble(Console.ReadLine());

if (prestacao <= (salario * 0.30))
{
    Console.WriteLine("O empréstimo pode ser concedido, o valor está dentro dos 30% permitido.");
}
else 
{
    Console.WriteLine("O empréstimo não pode ser concedido, o valor é maior que os 30% permitido.");
}
