using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeManagement
{
    class Cafe
    {

        //Default Constructor
        public Cafe()
        {
            newBeefB = 0.0;
            newElkB = 0.0;
            newMushroomB = 0.0;
            newTurkeyB = 0.0;
            newVeggieB = 0.0;
            newSalmonB = 0.0;
            newTunaB = 0.0;

            newShoestringF = 0.0;
            newBelgianF = 0.0;
            newStandardF = 0.0;
            newCrinkleF = 0.0;
            newSweetF = 0.0;
            newWaffleF = 0.0;
            newPotatoF = 0.0;
        }

        //Set Method
        public Cafe(double BeefB, double ElkB, double MushroomB, double TurkeyB, double VeggieB, double SalmonB, double TunaB,
                  double ShoestringF, double BelgianF, double StandardF, double CrinkleF, double SweetF, double WaffleF, double PotatoF)
        {
            newBeefB = newBeefB;
            newElkB = ElkB;
            newMushroomB = MushroomB;
            newTurkeyB = TurkeyB;
            newVeggieB = VeggieB;
            newSalmonB = SalmonB;
            newTunaB = TunaB;

            newShoestringF = ShoestringF;
            newBelgianF = BelgianF;
            newStandardF = StandardF;
            newCrinkleF = CrinkleF;
            newSweetF = SweetF;
            newWaffleF = WaffleF;
            newPotatoF = PotatoF;
              

        }

        //get Method
        public double getBeefB() { return newBeefB; }
        public double getElkB() { return newElkB; }
        public double getMushroomB() { return newMushroomB; }
        public double getTurkeyB() { return newTurkeyB; }
        public double getVeggieB() { return newVeggieB; }
        public double getSalmonB() { return newSalmonB; }
        public double getTunaB() { return newTunaB; }
        public double getShoestringF() { return newShoestringF; }
        public double getBelgianF() { return newBelgianF; }
        public double getStandardF() { return newStandardF; }
        public double getCrinkleF() { return newCrinkleF; }
        public double getSweetF() { return newSweetF; }
        public double getWaffleF() { return newWaffleF; }
        public double getPotatoF() { return newPotatoF; }


        //Coffee
        private double newBeefB;
        private double newElkB;
        private double newMushroomB;
        private double newTurkeyB;
        private double newVeggieB;
        private double newSalmonB;
        private double newTunaB;

        //Cakes
        private double newShoestringF;
        private double newBelgianF;
        private double newStandardF;
        private double newCrinkleF;
        private double newSweetF;
        private double newWaffleF;
        private double newPotatoF;
    }
}
