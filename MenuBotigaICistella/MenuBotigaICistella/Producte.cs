using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuBotigaICistella
{
    public class Producte
    {
        // Atributs 
        private string nom;
        private double preuSenseIVA;
        private double iva;
        private int quantitat;

        // Constructors
        public Producte()
        {
            nom = "";
            preuSenseIVA = 0;
            iva = 0.21; 
            quantitat = 0;
        }

        public Producte(string nom, double preuSenseIVA)
        {
            this.nom = nom;
            this.preuSenseIVA = preuSenseIVA;
            iva = 0.21; 
            quantitat = 0;
        }

        public Producte(string nom, double preuSenseIVA, double iva, int quantitat)
        {
            this.nom = nom;
            this.preuSenseIVA = preuSenseIVA;
            this.iva = iva;
            this.quantitat = quantitat;
        }

        // Propietats 
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public double PreuSenseIVA
        {
            get { return preuSenseIVA; }
            set
            {
                if (value >= 0)
                    preuSenseIVA = value;
            }
        }

        public double IVA
        {
            get { return iva; }
            set
            {
                if (value >= 0)
                    iva = value;
            }
        }

        public int Quantitat
        {
            get { return quantitat; }
            set
            {
                if (value >= 0)
                    quantitat = value;
            }
        }

        // Mètodes públics
        public double Preu()
        {
            return preuSenseIVA * (1 + iva);
        }

        public override string ToString()
        {
            return $"Nom: {nom}, Preu: {Preu()}, Quantitat: {quantitat}";
        }
    }
}