using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Classe_Astratta
{
    public class Ala : Component
    {
        private double _lung;
        private double _aper;

        public double Lung
        {
            get { return _lung; }
            set { _lung = value; }
        }

        public double Aper
        {
            get { return _aper; }
            set { _aper = value; }
        }

        public Ala()
        {
            Lung = 0F;
            Aper = 0F;
        }

        public Ala(double length, double wingspan)
        {
            Lung = length;
            Aper = wingspan;
        }

        public Ala(Ala oldWing)
        {
            Lung = oldWing.Lung;
            Aper = oldWing.Aper;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ala) || obj == null)
            {
                return false;
            }

            Ala other = (Ala)obj;
            return Lung == other.Lung && Aper == other.Aper;
        }

        public override void Aggiunta(Component component)
        {

        }

        public override bool Rimuovi(Component component)
        {
            return false;
        }

        public override Component GetChild(int index)
        {
            return null;
        }

        public override string ToString()
        {
            return $"Ala length: {Lung}; Wingspan: {Aper}";
        }

        public override double Prezzo()
        {
            return Lung * Aper;
        }
    }
}
