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
            set
            {
                if (value >= 15F)
                    _lung = value;
                else
                    _lung = 15F;
            }
        }

        public double Aper
        {
            get { return _aper; }
            set
            {
                if (value * 2F >= Lung)
                    _aper = value;
                else
                    _aper = Lung * 2F;
            }
        }

        public Ala()
        {
            Lung = 0F;
            Aper = 0F;
        }

        public Ala(double lung, double aper)
        {
            Lung = lung;
            Aper = aper;
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

        public override void Rimuovi(int index)
        {
            
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
