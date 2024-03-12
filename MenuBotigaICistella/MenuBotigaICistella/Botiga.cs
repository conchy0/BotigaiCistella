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

        public Producte TrobarProductePerNom(string nom)
        {
            for (int i = 0; i < nElements; i++)
            {
                if (productes[i] != null && productes[i].Nom == nom)
                {
                    return productes[i];
                }
            }
            Console.WriteLine($"No s'ha trobat cap produce amb = {nom}.");
            return null;
        }

        public int EspaiLliure()
        {
            return productes.Length - nElements;
        }

        public bool AfegirProducte(Producte producte)
        {
            if (nElements < productes.Length)
            {
                productes[nElements] = producte;
                nElements++;
                return false;
            }

            else
            {
                Console.WriteLine("La Botiga està plena");
                return true;
            }

        }

        public AfegirProducte(Producte[] producte)
        {
            int espaiLliure = EspaiLliure();
            if (productes.Length <= espaiLliure)
            {
                for (int i = 0; i < productes.Length; i++)
                {
                    this.productes[nElements + i] = productes[i];
                }
                nElements += productes.Length;
            }
            else
            {
                Console.WriteLine("No hi ha prou espai per afegir tots els productes.");
                Console.WriteLine("Voleu ampliar la tenda? (s/n);");
                string resposta = Console.ReadLine();
                if (resposta.ToLower() == "s")
                {
                    nElements++;
                }

            }
        }
    }
}
 