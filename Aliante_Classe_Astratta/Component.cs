using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aliante_Classe_Astratta
{
    public abstract class Component
    {
        public abstract void Aggiunta(Component componente);

        public abstract void Rimuovi(int index);

        public abstract Component GetChild(int index);

        public new abstract bool Equals(object obj);

        public new abstract string ToString();

        public abstract double Prezzo();
    }
}
