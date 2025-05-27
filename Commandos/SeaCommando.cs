using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class SeaCommando:Commando
    {
        public SeaCommando(string name, string codeName, string status):base(name, codeName, status)
        {

        }

        public void Swim()
        {
            Console.WriteLine("Commando is swimming");
        }

        public override void Attack()
        {
            Console.WriteLine($"Commando {CodeName} is attacking by sea.");
        }
    }
}
