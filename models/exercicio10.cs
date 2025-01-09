namespace Exercicios.Ex10
{
    public class VerificaVogalOuConsoante
    {
        public void Iniciar()
        {
            string letra;
            bool repetir = false;

            Console.WriteLine("Vou te dizer se vc digitou uma consoante ou uma vogal.");

            do
            {
                Console.WriteLine("Digite uma letra: ");
                letra = Console.ReadLine();

                letra = letra.ToUpper();

                if (letra.Length != 1)
                {
                    repetir = true;
                    Console.WriteLine("Entrada inválida! Digite apenas uma letra.");
                }
                else switch (letra)
                    {
                        case "0":
                        case "1":
                        case "2":
                        case "3":
                        case "4":
                        case "5":
                        case "6":
                        case "7":
                        case "8":
                        case "9":
                        case "10":
                            Console.WriteLine($"Isso não é uma letra, é um número!");
                            repetir = true;
                            break;

                        case "A":
                        case "E":
                        case "I":
                        case "O":
                        case "U":
                            Console.WriteLine($"A letra {letra} é uma Vogal!");
                            Console.WriteLine("Deseja Continuar?");
                            Console.WriteLine("S = Sim e N = Não");
                            string continuar = Console.ReadLine().ToUpper();
                            switch (continuar)
                            {
                                case "S":
                                    repetir = true;
                                    break;
                                case "N":
                                    repetir = false;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida! Encerrando o programa.");
                                    repetir = false;
                                    break;
                            }
                            break;

                        default:
                            Console.WriteLine($"A letra {letra} é uma Consoante!");
                            Console.WriteLine("Deseja Continuar?");
                            Console.WriteLine("S = Sim e N = Não");
                            continuar = Console.ReadLine().ToUpper();
                            switch (continuar)
                            {
                                case "S":
                                    repetir = true;
                                    break;
                                case "N":
                                    repetir = false;
                                    break;
                                default:
                                    Console.WriteLine("Opção inválida! Encerrando o programa.");
                                    repetir = false;
                                    break;
                            }
                            break;
                    }

            } while (repetir == true);
        }
    }
}
