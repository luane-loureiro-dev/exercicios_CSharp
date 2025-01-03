namespace Exercicios.Ex06
{
    public class CaracterCounter
    {
        private string texto;

        public CaracterCounter(string texto)
        {
            this.texto = texto.ToUpper();
        }

        public void ContarCaracteres()
        {
            string caracteresContados = "";

            for (int i = 0; i < texto.Length; i++)
            {
                int count = 0;

                if (caracteresContados.Contains(texto[i]))
                {
                    continue;
                }

                for (int j = 0; j < texto.Length; j++)
                {
                    if (texto[i] == texto[j])
                    {
                        count++;
                    }
                }

                Console.WriteLine($"Caractere '{texto[i]}' aparece {count} vez(es).");

                caracteresContados += texto[i];
            }
        }
    }
}