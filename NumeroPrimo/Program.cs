namespace NumeroPrimo;

public class Program
{
    public static void Main()
    {
        var Continuar = true;
        do
        {
            Console.Clear();
            Console.WriteLine("Verificador de números primos");
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Valores validos entre {int.MinValue} até {int.MaxValue}.");
            Console.Write($"Informe um número inteiro: ");
            


            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                Console.WriteLine("------------------------------");
                bool ehPrimo = Primo.VerificarSePrimo(numero);
                Console.WriteLine(ehPrimo
                    ? $"O número {numero} é primo."
                    : $"O número {numero} não é primo.");
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Entrada inválida. Por favor, informe um número inteiro.");
                Console.WriteLine();
            }

            Console.WriteLine("------------------------------");
            Console.Write("Deseja verificar outro número? Somente (S) para continuar: ");
            string? resposta = Console.ReadLine();
            if (resposta == null || !string.Equals(resposta.ToUpper(), "S", StringComparison.CurrentCultureIgnoreCase))
            {
                Continuar = false;
            }

        } while (Continuar);
        Console.Clear();
        Environment.Exit(0);

    }

}
