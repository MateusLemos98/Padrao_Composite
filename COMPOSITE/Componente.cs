using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE
{
    public abstract class Componente
    {
        public string Nome;

        public Componente(string nome)
        {
            this.Nome = nome;
        }

        public abstract void Mostrar();

    }
}
