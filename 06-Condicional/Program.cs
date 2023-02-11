using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 6 - Testando Condicionais");

        int idade = 20;
        int quantidadeDePessoas = 3; 

        if (idade >= 18)
        {
            Console.WriteLine("Você tem mais que 18 anos");
            Console.WriteLine("Seja bem vindo");
        } else {
            if (quantidadeDePessoas >= 2) 
            {
                Console.WriteLine("Você ainda não tem 18 anos, mas está acompanhado.");
                Console.WriteLine("Pode entrar");
            } else {
                Console.WriteLine("Infelizmente você não pode entrar");
            }
            
        }


        Console.WriteLine("Fim da execução do programa. Aperte o ENTER para encerrar a reprodução");
        Console.ReadLine();
    }
}
