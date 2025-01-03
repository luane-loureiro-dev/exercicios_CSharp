using System;

namespace Exercicios.Ex05
{
    public class OrdenarNumeros
{
    public int Numeros { get; set; }

    public OrdenarNumeros(int Numeros)
    {
        Texto = texto;
    }

    public string Inverter()
    {
        char[] arrayTexto = Texto.ToCharArray();
        Array.Reverse(arrayTexto);
        return new string(arrayTexto);
    }
}
}
