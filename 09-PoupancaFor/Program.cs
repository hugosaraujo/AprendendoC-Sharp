using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 9 - Calculando Poupança"); 

        double investimento = 1000;

      //while (mes <= 12)
     // {
     //     investimento = investimento + investimento * 0.005 %;
     //     Console.WriteLine("No mês " + mes + " você vai ter R$ " + investimento);
     //
     //     mes += 1;
     // }
        for (int mes = 1; mes <= 12; mes++) 
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você vai ter R$ " + investimento);
        }
        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}