using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
    public class Indirizzo
    {
        public string Name { get; set; }
        public string Cognome { get; set; }
        public string Strada { get; set; }
        public string Citta { get; set; }
        public string Provincia { get; set; }
        public int Cap { get; set; }

        public Indirizzo (string nome, string cognome, string strada, string citta, string provincia, int cap) 
        {
            Name = nome;
            Cognome = cognome;
            Strada = strada;
            Citta = citta;
            Provincia = provincia;
            Cap = cap;
        }

        
    }
}
