// Escreva um programa que leia uma string e conte o número de vezes que cada caractere aparece.

class ContandoCaracter
{
    static void Main(string[] args)
    {
        Console.Write("Digite uma string: ");
        string input = Console.ReadLine();

        input = input.ToUpper();

        for (int i = 0; i < input.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < input.Length; j++)
            {
                if (input[i] == input[j])
                {
                    count++;
                }
            }

            if (count > 0)
            {
                Console.WriteLine($"Caractere '{input[i]}' aparece {count} vez(es).");

                input = input.Replace(input[i].ToString(), "");
            }
        }
    }
}

