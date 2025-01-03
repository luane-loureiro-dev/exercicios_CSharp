// Escreva um programa que leia um array de números inteiros e encontre o maior elemento.

class MaiorNumero
{
    static void Main(string[] args)
    {
        Console.Write("Digite os números separados por espaço: ");
        string entrada = Console.ReadLine();

        int[] numeros = entrada.Split(' ').Select(int.Parse).ToArray();

        // Ordena em ordem crescente
        Array.Sort(numeros);

        // Pega o último elemento do array
        int ultimoElemento = numeros[numeros.Length - 1];

        // Exibe o último elemento
        Console.WriteLine($"Maior Numero: {ultimoElemento}");
        
    }
}

