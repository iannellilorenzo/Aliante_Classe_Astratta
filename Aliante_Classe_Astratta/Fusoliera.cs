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
        private string _materiale;

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

        public string Materiale
        {
            get { return _materiale; }
            set { _materiale = value; }
        }

        public Fusoliera()
        {
            Lung = 0F;
            Materiale = string.Empty;
        }

        public Fusoliera(double _lung, string materiale)
        {
            Lung = _lung;
            Materiale = materiale;
        }

        public Fusoliera(Fusoliera oldFusoliera)
        {
            Lung = oldFusoliera.Lung;
            Materiale = oldFusoliera.Materiale;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Fusoliera) || obj == null)
            {
                return false;
            }

            Fusoliera other = (Fusoliera)obj;
            return Lung == other.Lung && Materiale == other.Materiale;
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
            return $"Fusoliera _lung: {Lung}; Fusoliera material: {Materiale}";
        }

        public override double Prezzo()
        {
            return Lung * 30F;
        }
    }
}
