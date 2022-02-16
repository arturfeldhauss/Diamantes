using System;

namespace Diamantes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a quantidade de linhas!!");
            
            string colunas = Console.ReadLine();
            int colunass = Convert.ToInt32(colunas);
            //Parte de cima
            for (int linha = 0; linha <= colunass / 2 ; linha++) 
            {
                for (int j = 0; j < colunass - linha; j++) 
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * linha - 1;j++) 
                {
                    Console.Write("x");
                }
                Console.WriteLine("");     
            }
            //Linha do meio
            for (int j = 0; j < colunass / 2; j++) 
            {
                Console.Write(" ");

            }
            for (int j = 1; j < colunass + 1; j++) 
            {
                Console.Write("x");
            }

            Console.WriteLine("");        
            //Parte de baixo
            for (int i = colunass / 2; i >= 1;i--)
            {
                for (int j = 1; j <= colunass - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write("x");
                }
                Console.WriteLine("");
            }
            
            
            
            
            Console.ReadLine();




        }
    }
}
