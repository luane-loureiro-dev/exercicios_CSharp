namespace Exercicios.Ex08
{
    public class Soma
    {
        private int[] numeros;

        public Soma(int[] numeros)
        {
            this.numeros = numeros;
        }

        public int CalcularSoma()
        {
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                soma += numeros[i];
            }
            return soma;
        }
    }
}