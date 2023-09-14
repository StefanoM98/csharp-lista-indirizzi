using System;

namespace csharp_lista_indirizzi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Indirizzo> indirizzi = new List<Indirizzo>();
            try
            {
                StreamReader fileIndirizzo = File.OpenText("C:\\Users\\Utente\\source\\repos\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\my-addresses.csv");
                int numeroRiga = 0;

                while (!fileIndirizzo.EndOfStream)
                {
                    string riga = fileIndirizzo.ReadLine();
                    numeroRiga++;
                    
                    if (numeroRiga > 1)
                    {
                        string[] dividerePerArray = riga.Split(',');
                        if( dividerePerArray.Length < 6)
                        {
                            Console.WriteLine("Errore, alcuni dati dell'indirizzo non riesco a recuperarli!");
                        } else
                        {
                            string nome = dividerePerArray[0];
                            string cognome = dividerePerArray[1];
                            string strada = dividerePerArray[2];
                            string citta = dividerePerArray[3];
                            string provincia = dividerePerArray[4];
                            int cap = int.Parse(dividerePerArray[5]);

                            Console.WriteLine($"Questo è il tuo indirizzo: {nome}, {cognome}, {strada}, {citta}, {provincia}, {cap}");

                            Indirizzo nuovoIndirizzo = new Indirizzo(nome, cognome, strada, citta, provincia, cap);

                            indirizzi.Add(nuovoIndirizzo);
                        }
                    }
                }

                fileIndirizzo.Close();

            } catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}