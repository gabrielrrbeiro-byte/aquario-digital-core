using System;

public class ControleQualidadeAgua
{
    private double ph;
    private double temperatura;

    public ControleQualidadeAgua(double ph, double temperatura)
    {
        this.ph = ph;
        this.temperatura = temperatura;
    }

    public bool VerificarParametros()
    {
        if (ph < 6.8 || ph > 7.6)
        {
            Console.WriteLine("ALERTA QA: Nível de pH fora do limite ideal!");
            return false;
        }

        if (temperatura < 22.0 || temperatura > 28.0)
        {
            Console.WriteLine("ALERTA QA: Temperatura fora do limite seguro!");
            return false;
        }

        Console.WriteLine("STATUS: Parâmetros da água em níveis ideais.");
        return true;
    }

    public static void Main(string[] args)
    {
        ControleQualidadeAgua controle = new ControleQualidadeAgua(7.2, 25.0);
        controle.VerificarParametros();
    }
}