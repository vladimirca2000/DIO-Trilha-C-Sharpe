using System.Numerics;

namespace NumeroPrimo;
public class Primo
{
    public static bool VerificarSePrimo(int numero)
    {
        var ehPrimo = true;

        // Números menores que 2 não são primos
        if (numero < 2)
        {
            Console.WriteLine("Número menor que 2 não é primo então...");
            return false;
        }

        var raizAproximada = (int)Math.Sqrt(numero);      

        for (int i = 2; i <= raizAproximada; i++)
        {
            if (numero % i == 0)
            {
                ehPrimo = false;
                break;
            }
        }        
       
        return ehPrimo;
    }
}

