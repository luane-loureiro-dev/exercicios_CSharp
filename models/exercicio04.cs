namespace Exercicios.Ex04
{
    public class InversorDeTexto
{
    private string texto;

    public InversorDeTexto(string texto)
    {
        this.texto = texto;
    }
    
    public string Inverter()
    {
        char[] array = texto.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
}

