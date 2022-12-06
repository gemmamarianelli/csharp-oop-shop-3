using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_3
{
    internal class Prodotto
    {
        private int codice;
        private string nome;
        private string desrcizione;
        private int prezzo;
        private int iva;
        public Prodotto( string nome, string descrizione, int prezzo, int iva)
        {
            this.codice = CodiceRandom();
            this.nome = nome;
            this.desrcizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }

        //GETTER
        public int GetCodice()
        {
            return codice;
        }
        public string GetNome()
        {
            return nome;
        }
        public string GetDescrizione()
        {
            return desrcizione;
        }
        public double GetPrezzo()
        {
            return prezzo;
        }
        public int GetIVA()
        {
            return iva;
        }
        //SETTERS
        public void SetNome(string nome)
        {
            this.nome = nome;
        }
        public void SetDescrizione(string descrizione)
        {
            this.desrcizione = descrizione;
        }
        public void SetPrezo(double prezo)
        {
            this.prezzo = prezzo;
        }
        public void SetIVA(int iva)
        {
            this.iva = iva;
        }
        private int CodiceRandom()
        {
            Random random = new Random();
            int codiceRandom = random.Next(99999999 + 1);
            return codiceRandom;
        }
        //METODO
        public void Stampa()
        {
            Console.WriteLine("-------" + "PRODOTTO" + "-------");
            Console.WriteLine("codice: " + codice);
            Console.WriteLine("nome: " + nome);
            Console.WriteLine("descrizione: " + desrcizione);
            Console.WriteLine("prezzo: " + prezzo);
            Console.WriteLine("iva: " + iva);
            Console.WriteLine("----------------------");
        }
    }
   

}
