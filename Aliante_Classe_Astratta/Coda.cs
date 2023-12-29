using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Classe_Astratta
{
    public class Coda : Component
    {
        private double _lung;

        public double Lung
        {
            get { return _lung; }
            set
            {
                if (value >= 7F && value <= 12F)
                    _lung = value;
                else
                    _lung = 8F;
            }
        }

        public Coda()
        {
            Lung = 0F;
        }

        public Coda(double lung)
        {
            Lung = lung;
        }

        public Coda(Coda oldCoda)
        {
            Lung = oldCoda.Lung;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Coda) || obj == null)
            {
                return false;
            }

            Coda other = (Coda)obj;
            return Lung == other.Lung;
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
            return $"Coda length: {Lung}";
        }

        public override double Prezzo()
        {
            return Lung * 30;
        }
    }
}
