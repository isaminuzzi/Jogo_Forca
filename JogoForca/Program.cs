using System;

namespace JogoForca
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] palavras = {"banana", "maça", "melancia", "jaca", "jabuticaba", "manga"};
            Random randomico = new Random();
            int posicaoPalavra = randomico.Next(0, 6);            
            string palavra = palavras[posicaoPalavra];
            string letra = "";
            bool fim = false;
            string[] letras = new string[palavra.Length];
            int acertos = 0; 

            Console.WriteLine("\tJOGO DA FORCA\n");
            Console.WriteLine(palavra);
            
            while (!fim)
            {
                Console.WriteLine("\nDigite uma letra:");
                letra = Console.ReadLine();
                Console.WriteLine();
                //Console.Clear();
                for (int i = 0; i < palavra.Length; i++)
                {
                    letras[i] = palavra[i].ToString();
                    if (letra == letras[i])
                    {
                        Console.Write(letra + ' ');
                        acertos++;
                        
                    }
                    else
                    {
                        Console.Write("_ ");
                    }
                   
                }
                if (acertos == palavra.Length)
                {
                    Console.WriteLine("\nParabens, você acertou a resposta! A palavra é:" + palavra);
                    fim = true;
                } 
            }
            
        }
    }
}
