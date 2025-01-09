using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios.Ex03
{
    public class VerificaPrimo
{
    private int numero;

    public VerificaPrimo(int numero)
    {
        this.numero = numero;
    }

    public bool EhPrimo()
    {
        if (numero <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(numero); i++)
        {
            if (numero % i == 0)
                return false;
        }

        return true;
    }
}

}
