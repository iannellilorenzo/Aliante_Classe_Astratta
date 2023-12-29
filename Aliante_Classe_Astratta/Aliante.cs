using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Classe_Astratta
{
    public class Aliante : Component
    {
        private List<Component> _components;

        public List<Component> Components
        {
            get { return _components; }
            set { _components = value; }
        }

        public Aliante()
        {
            Components = new List<Component>();
        }

        public Aliante(List<Component> components)
        {
            Components = components;
        }

        public Aliante(Aliante oldAliante)
        {
            Components = oldAliante.Components;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Aliante) || obj == null)
            {
                return false;
            }

            Aliante other = (Aliante)obj;
            if (Components.Count != other.Components.Count)
            {
                return false;
            }

            for (int i = 0; i < Components.Count; i++)
            {
                if (!Components[i].Equals(other.Components[i]))
                {
                    return false;
                }
            }

            return true;
        }

        public override void Aggiunta(Component component)
        {
            Components.Add(component);
        }

        public override bool Rimuovi(Component component)
        {
            return Components.Remove(component);
        }

        public override Component GetChild(int index)
        {
            if (Components.Count > index)
            {
                return Components[index];
            }

            return null;
        }

        public override string ToString()
        {
            string str = "";

            foreach (var component in Components)
            {
                str += component;
            }

            return str;
        }

        public override double Prezzo()
        {
            double tot = 0;

            foreach (var component in Components)
            {
                tot += component.Prezzo();
            }

            return tot;
        }
    }
}
