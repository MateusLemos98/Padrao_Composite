using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPOSITE
{
    internal class Produto : Componente
    {

        private string _Url;

        public Produto(string nome, string url) : base(nome)
        {
            this._Url = url;
        }


        public override void Mostrar()
        {
            Console.WriteLine($"- {Nome} >> Redirecionando...{_Url}");
        }
    }
}
