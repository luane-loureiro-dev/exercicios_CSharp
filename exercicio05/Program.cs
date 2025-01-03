// Escreva um programa que leia um array de números inteiros e os ordene em ordem crescente.

using System;
using System.Linq;

class OrdenarNumeros
{
    static void Main(string[] args)
    {
        Console.Write("Digite os números separados por espaço: ");
        string entrada = Console.ReadLine();

        int[] numeros = entrada.Split(' ').Select(int.Parse).ToArray();

        Array.Sort(numeros);

        Console.WriteLine("Números ordenados em ordem crescente:");
        Console.WriteLine(string.Join(" ", numeros));
        
    }
}