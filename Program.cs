/* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica de Programação I
 * Professor Clayton Ferraz Andrade
 * 
 * Acadêmico Vinícius de Oliveira Pinheiro
 * Aula do dia 19-04-2023
 */

// 

int numero = 0, soma = 0, contador = 0;
Console.WriteLine("Vamos digitar números até que somem um valor igual " +
        "ou superior a 1000");
do
{
    Console.WriteLine("Digite um número positivo");
    numero = int.Parse(Console.ReadLine());
    // outra maneira de escrever o int.Parse é o Convert.ToInt32
    // numero = Convert.ToInt32(Console.ReadLine());
    soma = soma + numero; ;
    // outra maneira de denotar isto é 'soma += numero;'
    contador++;
} while (soma <= 999);

Console.WriteLine("\nA soma dos números digitados é igual a " + soma + ".");
Console.WriteLine("A quantidade de vezes digitadas foi " + contador + ".\n\n");

int number = 0, sum = 0, counter = 0;
Console.WriteLine("Vamos digitar números até que somem um valor igual " +
        "ou superior a 1000");
do
{
    Console.WriteLine("Digite um número positivo");
    number = int.Parse(Console.ReadLine());
    // outra maneira de escrever o int.Parse é o Convert.ToInt32
    // numero = Convert.ToInt32(Console.ReadLine());
    if (number >= 0)
    {
        sum = sum + number;
        counter++;
    }
    else
    {
        Console.WriteLine("Você digitou um número negativo." +
            "\nPor favor,");
    }
    // outra maneira de denotar isto é 'soma += numero;'
} while (sum <= 999);

Console.WriteLine("\nA soma dos números digitados é igual a " + sum + ".");
Console.WriteLine("A quantidade de vezes digitadas foi " + counter + ".\n");


int numerus = 0, summa = 0, calculus = 0;

do
{
    Console.WriteLine("Digite um número positivo: ");
    numerus = Convert.ToInt32(Console.ReadLine());

    if (numerus > 0 && numerus < 999)
    {
        summa += numerus;
        calculus++;
    }
    else
    {
        Console.WriteLine("Você digitou um número negativo ou maior que mil." +
            "\nPor favor,");
    }
} while (summa <= 999);
Console.WriteLine("\nVocê digitou " + calculus + " números, que juntos " +
    "somam " + summa);

Console.ReadLine();