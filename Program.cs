using Exercicios.Ex01;
using Exercicios.Ex02;
using Exercicios.Ex03;
using Exercicios.Ex04;
using Exercicios.Ex05;
using Exercicios.Ex06;
using Exercicios.Ex07;
using Exercicios.Ex08;
using Exercicios.Ex09;
using Exercicios.Ex10;

string opcao = "";

bool exibirMenu = true;

while (exibirMenu)
{
    Console.WriteLine("");
    Console.WriteLine("Qual Exeicicio quer testar?");
    Console.WriteLine("1 - Soma de Dois Números");
    Console.WriteLine("2 - Par ou Impar");
    Console.WriteLine("3 - Número Primo");
    Console.WriteLine("4 - Texto Invertido");
    Console.WriteLine("5 - Ordem Crescente");
    Console.WriteLine("6 - Contar Caractere");
    Console.WriteLine("7 - O Maior Número");
    Console.WriteLine("8 - Soma de uma array");
    Console.WriteLine("9 - Ordem Alfabética");
    Console.WriteLine("10 - Vogal Ou Consoante");
    Console.WriteLine("11 - Sair");
    Console.WriteLine("");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Exercício 01 - Soma de Dois Numeros");
            Console.WriteLine("");

            //soma de dois numeros
            Ex01 ex01 = new Ex01();
            int resultadoEx01 = ex01.SomaDoisNumeros(1, 1);
            Console.WriteLine($"A soma é {resultadoEx01}");

            break;

        case "2":
            Console.WriteLine("Exercício 02 - Par ou Impar");
            Console.WriteLine("");

            // par ou impar
            Console.Write("Digite um número inteiropara saber se ele é par ou impar: ");
            int numeroParImpar = int.Parse(Console.ReadLine());
            VerificadorParOuImpar verificador = new VerificadorParOuImpar(numeroParImpar);
            verificador.Verificar();

            break;

        case "3":
            Console.WriteLine("Exercício 03 - Número Primo");
            Console.WriteLine("");

            // numero primo
            Console.Write("Digite um número inteiro para saber se ele é primo: ");
            int numeroPrimo = int.Parse(Console.ReadLine());
            VerificaPrimo verificadorDePrimos = new VerificaPrimo(numeroPrimo);
            if (verificadorDePrimos.EhPrimo())
            {
                Console.WriteLine($"O número {numeroPrimo} é primo.");
            }
            else
            {
                Console.WriteLine($"O número {numeroPrimo} não é primo.");
            }


            break;

        case "4":
            Console.WriteLine("Exercício 04 - Texto Invertido");
            Console.WriteLine("");

            //texto invertido
            Console.Write("Digite um testo para inverter: ");
            string entrada = Console.ReadLine();

            InversorDeTexto inversor = new InversorDeTexto(entrada);

            string resultado = inversor.Inverter();
            Console.WriteLine($"String invertida: {resultado}");

            break;

        case "5":
            Console.WriteLine("Exercício 05 - Ordem Crescente");
            Console.WriteLine("");

            //Ordenar numeros em ordem crescente
            Console.Write("Digite os números separados por espaço para que sejam colocados em ordem crescente: ");
            string entradaParaOrdenar = Console.ReadLine();
            int[] numerosParaOrdenar = Array.ConvertAll(entradaParaOrdenar.Split(' '), int.Parse);

            Ordenador ordenador = new Ordenador(numerosParaOrdenar);
            ordenador.Ordenar();
            ordenador.Exibir();

            break;

        case "6":
            Console.WriteLine("Exercício 06 - Número de Vezes que Cada Caractere Aparece");
            Console.WriteLine("");

            //conte o número de vezes que cada caractere aparece
            Console.Write("Digite uma texto para ver quantas vezes cada caractere aparece: ");
            string input = Console.ReadLine() ?? string.Empty;
            CaracterCounter contador = new CaracterCounter(input);
            contador.ContarCaracteres();

            break;

        case "7":
            Console.WriteLine("Exercício 07 - O Maior Número");
            Console.WriteLine("");

            //mostra o maior numero digitado
            Console.Write("Digite os números separados por espaço para mostrar qual o maior: ");
            string entradaMaior = Console.ReadLine();
            int[] numerosMaior = Array.ConvertAll(entradaMaior.Split(' '), int.Parse);
            OrdenadorMaior ordenadorMaior = new OrdenadorMaior(numerosMaior);
            ordenadorMaior.PegarMaiorNumero();
            ordenadorMaior.ExibirMaior();

            break;

        case "8":
            Console.WriteLine("Exercício 08 - Soma de uma Array");
            Console.WriteLine("");

            //leia um array de números inteiros e calcule a soma dos seus elementos

            Console.Write("Digite os números separados por espaço para calcular a soma entre eles: ");
            string entradaSomaArray = Console.ReadLine() ?? string.Empty;

            int[] numerosSomaArray = entradaSomaArray.Split(' ').Select(int.Parse).ToArray();

            Soma soma = new Soma(numerosSomaArray);

            int resultadoSomaArray = soma.CalcularSoma();
            Console.WriteLine($"A soma dos números é: {resultadoSomaArray}");

            break;

        case "9":
            Console.WriteLine("Exercício 09");
            Console.WriteLine("Ordem Alfabética");

            //Coloca em Ordem Alfabética
            Console.Write("Digite os nomes separados por espaço: ");
            string entradaAlfabertica = Console.ReadLine() ?? string.Empty;
            string[] nomesAlfabeticos = entradaAlfabertica.Split(' ');
            OrdemAlfabetica ordem = new OrdemAlfabetica(nomesAlfabeticos);
            ordem.Ordenar();
            ordem.ExibirNomes();

            break;

        case "10":

            Console.WriteLine("Exercício 10 (Extra) - Vogal ou Consoante");
            Console.WriteLine("");

            VerificaVogalOuConsoante verificacao = new VerificaVogalOuConsoante();
            verificacao.Iniciar();

            break;

        case "11":
            Console.WriteLine("Encerrando o Programa...");
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("opção inválida");
            break;
    }

}
Console.WriteLine("Obrigado!");










