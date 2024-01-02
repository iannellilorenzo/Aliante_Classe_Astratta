using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Classe_Astratta
{
    public class Aliante : Composite
    {
        private List<Composite> _components;

        public List<Composite> Composites
        {
            get { return _components; }
            set { _components = value; }
        }

        public Aliante()
        {
            Composites = new List<Composite>();
        }

        public Aliante(List<Composite> components)
        {
            Composites = components;
        }

        public Aliante(Aliante oldAliante)
        {
            Composites = oldAliante.Composites;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aliante) || obj == null)
            {
                return false;
            }

            Aliante other = (Aliante)obj;
            if (Composites.Count != other.Composites.Count)
            {
                return false;
            }

            for (int i = 0; i < Composites.Count; i++)
            {
                if (!Composites[i].Equals(other.Composites[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override void Aggiunta(Composite component)
        {
            Composites.Add(component);
        }

        public override void Rimuovi(int index)
        {
            Composites.RemoveAt(index);
        }

        public override Composite GetChild(int index)
        {
            if (Composites.Count > index)
            {
                return Composites[index];
            }

            return null;
        }

        public override string ToString()
        {
            string str = "";

            foreach (var component in Composites)
            {
                str += component.ToString();
            }

            return str;
        }

        public override double Prezzo()
        {
            double tot = 0;

            foreach (var component in Composites)
            {
                tot += component.Prezzo();
            }

            return tot;
        }
    }
}
