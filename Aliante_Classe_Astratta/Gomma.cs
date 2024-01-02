using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Classe_Astratta
{
    public class Gomma : Component
    {
        private double _alt;
        private double _larg;
        private double _raggio;

        public double Alt
        {
            get { return _alt; }
            set
            {
                if (value >= 200F && value <= 400F)
                    _alt = value;
                else
                    _alt = 300F;
            }
        }

        public double Larg
        {
            get { return _larg; }
            set
            {
                if (value >= 200F && value <= 400F)
                    _larg = value;
                else
                    _larg = 300F;
            }
        }

        public double Raggio
        {
            get { return _raggio; }
            set
            {
                if (value >= 40F && value <= 60F)
                    _raggio = value;
                else
                    _raggio = 50F;
            }
        }

        public Gomma()
        {
            Alt = 0F;
            Larg = 0F;
            Raggio = 0F;
        }

        public Gomma(double alt, double larg, double raggio)
        {
            Alt = alt;
            Larg = larg;
            Raggio = raggio;
        }

        public Gomma(Gomma oldGomma)
        {
            Alt = oldGomma.Alt;
            Larg = oldGomma.Larg;
            Raggio = oldGomma.Raggio;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Gomma) || obj == null)
            {
                return false;
            }

            Gomma other = (Gomma)obj;
            return Alt == other.Alt && Larg == other.Larg && Raggio == other.Raggio;
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
            return $"Altezza: {Alt}; Larghezza: {Larg}; Raggio: {Raggio}";
        }

        public override double Prezzo()
        {
            return Alt * Larg * Raggio * 10F;
        }
    }
}
