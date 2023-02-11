using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Criando Variáveis de Ponto Flutuante");

        double salarioMinimo = 1320.00;
        Console.WriteLine("O salário mínimo no Brasil hojé é de " + salarioMinimo + " reais.");

        double cotacaoDolarAmericano = 5.15;
        Console.WriteLine(cotacaoDolarAmericano);

        double divisaoSimples = 7 / 5;
        Console.WriteLine(divisaoSimples);

        divisaoSimples = 7.0 / 5;
        Console.WriteLine(divisaoSimples);

        Console.WriteLine("Fim da execução do programa. Aperte o ENTER para encerrar a reprodução");
        Console.ReadLine();
    }
}