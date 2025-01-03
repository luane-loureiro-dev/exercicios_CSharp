using Exercicios.Ex01;
using Exercicios.Ex02;
using Exercicios.Ex03;
using Exercicios.Ex04;
using Exercicios.Ex05;
using Exercicios.Ex06;
using Exercicios.Ex07;
using Exercicios.Ex08;
using Exercicios.Ex09;



//soma de dois numeros
Ex01 ex01 = new Ex01();
int resultadoEx01 = ex01.SomaDoisNumeros(1, 1);
Console.WriteLine($"A soma é {resultadoEx01}");


// par ou impar
Console.Write("Digite um número inteiropara saber se ele é par ou impar: ");
int numeroParImpar = int.Parse(Console.ReadLine());
VerificadorParOuImpar verificador = new VerificadorParOuImpar(numeroParImpar);
verificador.Verificar();


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


//texto invertido
Console.Write("Digite um testo para inverter: ");
string entrada = Console.ReadLine();

InversorDeTexto inversor = new InversorDeTexto(entrada);

string resultado = inversor.Inverter();
Console.WriteLine($"String invertida: {resultado}");


//Ordenar numeros em ordem crescente
Console.Write("Digite os números separados por espaço para que sejam colocados em ordem crescente: ");
string entradaParaOrdenar = Console.ReadLine();
int[] numerosParaOrdenar = Array.ConvertAll(entradaParaOrdenar.Split(' '), int.Parse);

Ordenador ordenador = new Ordenador(numerosParaOrdenar);
ordenador.Ordenar();
ordenador.Exibir();


//conte o número de vezes que cada caractere aparece
Console.Write("Digite uma texto para ver quantas vezes cada caractere aparece: ");
string input = Console.ReadLine() ?? string.Empty;
CaracterCounter contador = new CaracterCounter(input);
contador.ContarCaracteres();


//mostra o maior numero digitado
Console.Write("Digite os números separados por espaço para mostrar qual o maior: ");
string entradaMaior = Console.ReadLine();
int[] numerosMaior = Array.ConvertAll(entradaMaior.Split(' '), int.Parse);
OrdenadorMaior ordenadorMaior = new OrdenadorMaior(numerosMaior);
ordenadorMaior.PegarMaiorNumero();
ordenadorMaior.ExibirMaior();


//leia um array de números inteiros e calcule a soma dos seus elementos
Console.Write("Digite os números separados por espaço para calcular a soma entre eles: ");
string entradaSomaArray = Console.ReadLine() ?? string.Empty;

int[] numerosSomaArray = entradaSomaArray.Split(' ').Select(int.Parse).ToArray();

Soma soma = new Soma(numerosSomaArray);

int resultadoSomaArray = soma.CalcularSoma();
Console.WriteLine($"A soma dos números é: {resultadoSomaArray}");


//Coloca em Ordem Alfabética
Console.Write("Digite os nomes separados por espaço: ");
string entradaAlfabertica = Console.ReadLine() ?? string.Empty;
string[] nomesAlfabeticos = entradaAlfabertica.Split(' ');

// Instancia a classe OrdemAlfabetica
OrdemAlfabetica ordem = new OrdemAlfabetica(nomesAlfabeticos);

// Ordena os nomes e exibe o resultado
ordem.Ordenar();
ordem.ExibirNomes();





