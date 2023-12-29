using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Classe_Astratta
{
    public class Ruota : Component
    {
        private Gomma _gomma;
        private Cerchione _cerchione;

        public Gomma Gomma
        {
            get { return _gomma; }
            set { _gomma = value; }
        }

        public Cerchione Cerchione
        {
            get { return _cerchione; }
            set { _cerchione = value; }
        }

        public Ruota()
        {
            Gomma = new Gomma();
            Cerchione = new Cerchione();
        }

        public Ruota(Gomma gomma, Cerchione cerchione)
        {
            Gomma = gomma;
            Cerchione = cerchione;
        }

        public Ruota(Ruota oldRuota)
        {
            Gomma = oldRuota.Gomma;
            Cerchione = oldRuota.Cerchione;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Ruota) || obj == null)
            {
                return false;
            }

            Ruota other = (Ruota)obj;
            return Gomma == other.Gomma && Cerchione == other.Cerchione;
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
            return $"Ruota tire details: {Gomma}; Ruota rim details: {Cerchione}";
        }

        public override double Prezzo()
        {
            return 0;
        }
    }
}
