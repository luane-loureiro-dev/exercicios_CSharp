namespace Exercicios.Ex11
{
    public class VerificadorEntrada
    {
        public void Verificar()
        {
            string nome = "";
            int anoNascimento = 0;
            int idade = 0;
            int anoAtual = 0;
            bool ehMaiorDeIdade = false;
            bool possueAutorizacao = false;

            Console.WriteLine("Essa festa vai ser de arrazar, será que você pode entrar?");
            Console.WriteLine("Vou precisar de algumas informações pessoais: ");

            Console.WriteLine("Qual o seu Nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual o ano do seu nascimento?");
            anoNascimento = int.Parse(Console.ReadLine());
            anoAtual = DateTime.Now.Year;
            idade = anoAtual - anoNascimento;

            // Correção: Verifica se a pessoa é maior de idade
            ehMaiorDeIdade = idade >= 18;

            Console.WriteLine("Possue autorizção dos seus pais?");
            Console.WriteLine("S = Sim e N = Não");
            string entrada = Console.ReadLine().ToUpper();
            switch (entrada)
            {
                case "S":
                    possueAutorizacao = true;
                    break;

                case "N":
                    possueAutorizacao = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida! Encerrando o programa.");
                    possueAutorizacao = false;
                    break;
            }

            if (ehMaiorDeIdade || possueAutorizacao)
            {
                Console.WriteLine($"Ok, {nome} você tem {idade} anos, Sua Entrada está liberada!");
            }
            else
            {
                Console.WriteLine($"{nome} você tem {idade} e não tem autorização dos seus pais.");
                Console.WriteLine("Não posso deixar você entrar!");
            }
        }
    }
}