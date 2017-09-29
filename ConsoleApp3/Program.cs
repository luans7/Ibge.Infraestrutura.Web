using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.I

namespace ConsoleApp3
{
    class Program1: pro
    {
        static void Main(string[] args)
        {
            int opcao;
            int codigoAluno = 51;
            do
            {
                System.Console.WriteLine("[ 1 ] Ler Arquivo");
                System.Console.WriteLine("[ 2 ]Escrever Arquivo");
                opcao = Int32.Parse(System.Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        matricularAluno(codigoAluno);
                        break;
                    case 2:
                        cancelarMatricula(codigoAluno);
                        break;
                    default:
                        saiPrograma();
                        break;
                }
                System.Console.ReadKey();
                System.Console.Clear();
            }
            while (opcao != 0);
        }


        private static void saiPrograma()
        {
            Console.WriteLine();
            Console.WriteLine("Bye Bye, vc saiu do Programa. Clique qq tecla para sair...");
        }

        private static void cancelarMatricula(int codigoAluno)
        {
            Console.WriteLine();
            Console.WriteLine("Digitou a opção de Cancelar a Matricula");
        }

        private static void matricularAluno(int codigoAluno)
        {
            Console.WriteLine();
            Console.WriteLine("Digitou a opção de Matricular o Aluno");
        }
    }
    
}
