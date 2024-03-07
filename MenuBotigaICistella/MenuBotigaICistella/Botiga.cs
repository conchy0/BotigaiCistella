using System;

namespace MenuBotigaICistella
{
    internal class Botiga
    {
        private string nomBotiga;
        private int nElements;
        private Producte[] productes;

        public Botiga()
        {
            productes = new Producte[10];
            nElements = 0;
        }

        public Botiga(string nomBotiga, int nombreProductes)
        {
            this.nomBotiga = nomBotiga;
            productes = new Producte[nombreProductes];
            nElements = 0;
        }

        public Botiga(string nomBotiga, Producte[] productes)
        {
            this.nomBotiga = nomBotiga;
            this.productes = productes;
            nElements = productes.Length;
        }



        public int EspaiLliure()
        {
            return productes.Length - nElements;
        }
    }
}
