using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp30._1
{
    class Bankrekening : InterfaceObject
    {
        private double _rentevoet = 2.3;
        private double _saldo = 1000;

        public double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public double Rentevoet
        {
            get { return _rentevoet; }
            set { _rentevoet = value; }
        }
        public Bankrekening()
        {

        }
        public Bankrekening(double saldo, double rentevoet)
        {
            Saldo = saldo;
            Rentevoet = rentevoet;
        }
        public double Bereken()
        {
            return Saldo * (1 + Rentevoet / 100);
        }

        public override string ToString()
        {
            return $"De intrest vd rekening met saldo € 1000 en rentevoet 2,30 is {Bereken()}";
        }
    }
}
