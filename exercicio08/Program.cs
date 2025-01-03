// Escreva um programa que leia um array de números inteiros e calcule a soma dos seus elementos.

class MaiorNumero
{
    static void Main(string[] args)
    {
        Console.Write("Digite os números separados por espaço: ");
        string entrada = Console.ReadLine();

        int[] numeros = entrada.Split(' ').Select(int.Parse).ToArray();

        int soma = 0;
        for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }

        Console.WriteLine($"A soma dos Numeros é: {soma}");
        
    }
}