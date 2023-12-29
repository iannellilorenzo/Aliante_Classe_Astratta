using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Classe_Astratta
{
    public class Fusoliera : Component
    {
        private double _lung;
        private string _material;

        public double Lung
        {
            get { return _lung; }
            set
            {
                if (value >= 75F)
                    _lung = value;
                else
                    _lung = 75F;
            }
        }

        public string Material
        {
            get { return _material; }
            set { _material = value; }
        }

        public Fusoliera()
        {
            Lung = 0F;
            Material = string.Empty;
        }

        public Fusoliera(double _lung, string material)
        {
            Lung = _lung;
            Material = material;
        }

        public Fusoliera(Fusoliera oldFusoliera)
        {
            Lung = oldFusoliera.Lung;
            Material = oldFusoliera.Material;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Fusoliera) || obj == null)
            {
                return false;
            }

            Fusoliera other = (Fusoliera)obj;
            return Lung == other.Lung && Material == other.Material;
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
            return $"Fusoliera _lung: {Lung}; Fusoliera material: {Material}";
        }

        public override double Prezzo()
        {
            return Lung * 30F;
        }
    }
}
