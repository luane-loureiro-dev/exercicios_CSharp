namespace Exercicios.Ex09
{
    public class OrdemAlfabetica
    {
        private string[] nomes;

        public OrdemAlfabetica(string[] nomes)
        {
            this.nomes = nomes;
        }

        public void Ordenar()
        {
            Array.Sort(nomes);
        }

        public void ExibirNomes()
        {
            Console.WriteLine("Nomes em ordem alfabética:");
            Console.WriteLine(string.Join(", ", nomes));
        }
    }
}