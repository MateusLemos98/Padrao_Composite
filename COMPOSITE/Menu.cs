using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE
{
    internal class Menu : Componente
    {
        private List<Componente> componentes;


        public Menu(string nome) : base(nome)
        {
            componentes = new List<Componente>();
        }

        public void Adicionar(Componente componente)
        {
           
            componentes.Add(componente);

        }

        public void Remover(Componente componente)
        {

            componentes.Remove(componente);
        }


        public override void Mostrar()
        {
            Console.WriteLine($"{Nome}");
            foreach (Componente componente in componentes)
            {
                componente.Mostrar();
            }
        }
    }
}
