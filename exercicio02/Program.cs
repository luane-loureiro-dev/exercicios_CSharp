//Escreva um programa que leia um número inteiro e determine se ele é par ou ímpar.

using Exercicios.Ex02;

class ParOuImpar
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        int numero = int.Parse(Console.ReadLine());

        VerificadorParOuImpar verificador = new VerificadorParOuImpar(numero);
        verificador.Verificar();
    }
}