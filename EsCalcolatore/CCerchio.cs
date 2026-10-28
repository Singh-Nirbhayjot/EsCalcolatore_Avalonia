using System;
using System.Collections.Generic;
using System.Text;

namespace EsCalcolatore
{
    public class CCerchio : CFigura
    {
        private double raggio;
        public double Raggio
        {
            get { return raggio; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Il raggio deve essere maggiore di zero.");
                raggio = value;
            }
        }
        public CCerchio(string nome, double r) : base(nome)
        {
            Raggio = r;
        }
        public override double Area()
        {
            return (Math.PI* (Raggio * Raggio));
        }
        public override double Perimetro()
        {
            return 2 * Math.PI * Raggio;
        }
    }
}
