using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Ex02
{
    public class VerificadorParOuImpar
        {
            private int numero;
            public VerificadorParOuImpar(int numero)
                {
                    this.numero = numero;
                }

            public void Verificar()
                {
                    if (numero % 2 == 0)
                        {
                            Console.WriteLine($"O número {numero} é par.");
                        }
                    else
                        {
                            Console.WriteLine($"O número {numero} é ímpar.");
                        }
                }
        }
}


