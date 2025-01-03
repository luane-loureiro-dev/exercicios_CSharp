using System;

class OrdemAlfabetica
{
    static void Main(string[] args)
    {
        Console.Write("Digite os nomes separados por espaço: ");
        string entrada = Console.ReadLine();
        string[] nomes = entrada.Split(' ');

        Array.Sort(nomes);

        Console.WriteLine("Nomes em ordem alfabética:");
        Console.WriteLine(string.Join(", ", nomes));
        
    }
}