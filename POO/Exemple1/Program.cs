using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple1
{

    public class Vehicule
    {
        public int Puissance;
        public string Marque;
        public int Places;
        private int KilometreParcourus;

        
        public Vehicule(string chaine)
        {
            Marque = chaine;
        }

        public virtual void Avance(int km)
        {
            KilometreParcourus += km;
            Console.WriteLine("Le Vehicule avance " + km);
        }

    }    public class Voiture : Vehicule 
    {
        public Voiture(string m) : base(m)
        {

        }

        public override void Avance(int km)
        {
            //base.Avance(km);
            Console.WriteLine("C'est la voiture qui roule");
        }

    }    public class Avion : Vehicule
    {
        public Avion(string m) : base(m)
        {

        }

        public override void Avance(int km)
        {
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule[] garage = new Vehicule[3];

            garage[0] = new Vehicule("Citroen");
            garage[1] = new Avion("AirBus");
            garage[2] = new Voiture("BMW");


            foreach (Vehicule v in garage)
            {
                v.Avance(50);
            }
            




            

        }
    }
}
