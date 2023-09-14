using System;

namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Indirizzo> indirizzi = new List<Indirizzo>();

            StreamReader fileIndirizzo = File.OpenText("C:\\Users\\Utente\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");

            while (!fileIndirizzo.EndOfStream)
            {
                string line = fileIndirizzo.ReadLine();
                    
                Console.WriteLine(line);
            }
        }
    }
}