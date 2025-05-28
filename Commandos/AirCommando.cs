using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class AirCommando:Commando,IParachute
    {
        public AirCommando(string name, string codeName, string status) : base(name, codeName, status)
        {

        }

        public void Parachute()
        {
            Console.WriteLine("Commando is parachuting out of plane.");
        }

        public override void Attack()
        {
            Console.WriteLine($"Commando {CodeName} is attacking by air.");
        } 

    }
}
