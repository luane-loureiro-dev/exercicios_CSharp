//Escreva um programa que leia um número inteiro e determine se ele é primo.

using Exercicios.Ex03;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        VerificaPrimo verificador = new VerificaPrimo(numero);

        if (verificador.EhPrimo())
        {
            Console.WriteLine($"O número {numero} é primo.");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é primo.");
        }
    }
}
