using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class Program
{
    public static void Main()
    {

   
        
            // Usamos um tipo var que mais simples
            using (var writer = new StreamWriter("Menu_Ano_Mes_Dia_HH_M_S"))
            {
                // Percorre o laço
                for (int i = 0; i < 10; i++)
                {
                    // Escreve uma string formatada no arquivo
                    writer.Write("{0:0.0} ", i);
                }
            }
        


       
    }


   
}




