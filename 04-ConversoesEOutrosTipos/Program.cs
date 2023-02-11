using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 4 - Conversões e Outros Tipos ");
        double salario = 1133.00;

        int salarioInteiro = (int)salario;
        Console.WriteLine("Meu salário é: " + salarioInteiro + " reais.");

        long x = 270000000000000;
        Console.WriteLine(x);

        short y = 14000;
        Console.WriteLine(y);

        float altura = 1.91f;
        Console.WriteLine("A minha altura é " + altura);

        double valor1 = 0.1;
        double valor2 = 0.2; 
        double total = valor1 + valor2;
        Console.WriteLine(total);

        Console.WriteLine("Fim da execução do programa. Aperte o ENTER para encerrar a reprodução");
        Console.ReadLine();
    }
}