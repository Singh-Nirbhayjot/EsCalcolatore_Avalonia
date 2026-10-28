using System;
using System.Collections.Generic;
using System.Text;

namespace EsCalcolatore
{
    public abstract class CFigura
    {
        public string Nome { get; set; }
        public CFigura(string Nome)
        {
            this.Nome = Nome;
        }
        public abstract double Area();
        public abstract double Perimetro();
        public string Descrizione()
        {
            return $"Nome: {Nome}, Area: {Area():F2}, Perimetro: {Perimetro():F2}";
        }
    }
}
