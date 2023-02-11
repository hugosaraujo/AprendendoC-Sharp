using System;

class Program 
{
    static void Main(string[] args)
    {
        double salario = 3300.00;
        string aliquotaSalario;
        int reducao; 

        if(salario >= 1900.0 && salario <= 2800.0)
        {
            aliquotaSalario = "7,5%";
            reducao = 142;
            Console.WriteLine("A sua alíquota é de " + aliquotaSalario);
            Console.WriteLine("Você pode deduzir até R$ " + reducao);
        } 
        if(salario > 2800.00 && salario <= 3751.00)
        {
            aliquotaSalario = "15%";
            reducao = 350;

            Console.WriteLine("A sua alíquota é de " + aliquotaSalario);
            Console.WriteLine("Você pode deduzir até R$ " + reducao);
        }
        if(salario > 3751.00 && salario <= 4664.00)
        {
            aliquotaSalario = "22,5%";
            reducao = 636;

            Console.WriteLine("A sua alíquota é de " + aliquotaSalario);
            Console.WriteLine("Você pode deduzir até R$ " + reducao);
        }
    }
}