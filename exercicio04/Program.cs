// Escreva um InverterStringa que leia uma string e imprima a string invertida.

using Exercicios.Ex04;

class InverterString
{
    static void Main(string[] args)
    {
        Console.Write("Digite um Texto: ");
        string entrada = Console.ReadLine();

        StringModel stringModel = new StringModel(entrada);

        string resultado = stringModel.Inverter();
        Console.WriteLine($"Texto invertido: {resultado}");
    }
}