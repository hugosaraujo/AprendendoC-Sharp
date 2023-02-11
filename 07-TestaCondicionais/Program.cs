using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 7 - Testando Condicionais 2 ");

        int idade = 16;
        int quantidadeDePessoas = 3;
        
        bool acompanhado;

        if (quantidadeDePessoas>= 2) { 
            acompanhado = true;
        } else { 
            acompanhado = false;
        }

        if (idade >= 18 || acompanhado)
        {
             Console.WriteLine("Seja bem vindo");
        }
        else
        {
            Console.WriteLine("Infelizmente você não pode entrar");

        }


        Console.WriteLine("Fim da execução do programa. Aperte o ENTER para encerrar a reprodução");
        Console.ReadLine();
    }
}
