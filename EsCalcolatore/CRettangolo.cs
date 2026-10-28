using System;
using System.Collections.Generic;
using System.Text;

namespace EsCalcolatore
{
    public class CRettangolo : CFigura
    {
        private double _base;
        private double altezza;

        public double Base
        {
            get { return _base; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("La base deve essere maggiore di zero.");
                _base = value;
            }
        }
        public double Altezza
        {
            get { return altezza; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("L'altezza deve essere maggiore di zero.");
                altezza = value;
            }
        }

        public CRettangolo(string nome, double b, double h) : base(nome)
        {
            Base = b;       
            Altezza = h;
        }
        public override double Area()
        {
            return Base * Altezza;
        }
        public override double Perimetro()
        {
            return Base * 2 + Altezza * 2;
        }
    }
}
