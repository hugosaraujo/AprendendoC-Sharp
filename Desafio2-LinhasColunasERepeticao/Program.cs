using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Desafio 2 - Contagem em colunas e linhas");

        for (int linha = 0; linha < 5; linha++) 
        { 
            for (int coluna = 0; coluna < 5; coluna++) 
            { 
                if (coluna > linha)
                { 
                    break;
                }
                Console.Write(coluna + 1);
            }
            Console.WriteLine();
        }

        Console.WriteLine("Fim da execução do programa. Tecle ENTER para sair...");
        Console.ReadLine();
    }
}
