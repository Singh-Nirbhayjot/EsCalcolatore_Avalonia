using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace EsCalcolatore
{
    public class CQuadrato : CRettangolo
    {
        
        public CQuadrato(string nome, double lato) : base(nome, lato, lato)
        {
        }
        public double lato
        {
            get { return Base; }
            set
            {
                Base = value;
                Altezza = value;
            }
        }
        public override double Area()
        {
            return lato * lato;
        }
        public override double Perimetro()
        {
            return lato * 4;
        }
    }
}
