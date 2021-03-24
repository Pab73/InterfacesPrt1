using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp30._1
{
    class Figuur : InterfaceObject
    {
        private double _breedte = 10;
        private double _lengte = 30;

        public double Lengte
        {
            get { return _lengte; }
            set { _lengte = value; }
        }

        public double Breedte
        {
            get { return _breedte; }
            set { _breedte = value; }
        }
        public Figuur()
        {

        }
        public Figuur(double lengte, double breedte)
        {
            Lengte = lengte;
            Breedte = breedte;
        }

        public double Bereken()
        {
            return Lengte * Breedte;
        }
        public override string ToString()
        {
            return $"De opp vd figuur met lengte 30 en breedte 10 is {Bereken()} cm";
        }
    }
}
