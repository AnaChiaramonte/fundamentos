using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace defundamentos
{
    //erdando os atributos eé so colocar ":" e o nome do atributo
    public class Gato : Animal
    {
        public override void emitirSom()
        {
            Console.WriteLine("Miau Miau");
        }
    }
}
