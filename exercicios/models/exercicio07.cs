namespace Exercicios.Ex07
{
    public class OrdenadorMaior
    {
        private int[] numerosMaior;
        private int ultimoElemento; // Variável de instância para armazenar o maior número

        public OrdenadorMaior(int[] numerosMaior)
        {
            this.numerosMaior = numerosMaior;
        }

        public void PegarMaiorNumero()
        {
            // Ordena em ordem crescente
            Array.Sort(numerosMaior);

            // Pega o último elemento do array e armazena na variável de instância
            ultimoElemento = numerosMaior[numerosMaior.Length - 1];
        }

        public void ExibirMaior()
        {
            Console.WriteLine($"Maior Numero: {ultimoElemento}");
        }
    }
}
