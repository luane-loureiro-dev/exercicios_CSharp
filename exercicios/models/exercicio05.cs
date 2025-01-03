namespace Exercicios.Ex05
{
    public class Ordenador
    {
        private int[] numeros;

        public Ordenador(int[] numeros)
        {
            this.numeros = numeros;
        }

        public void Ordenar()
        {
            Array.Sort(numeros);
        }

        public void Exibir()
        {
            Console.WriteLine("Array ordenado: " + string.Join(", ", numeros));
        }
    }

}

