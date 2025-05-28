using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Commando
    {
        private string Name;
        public string CodeName { get ; set; }
        public string[] Utensils = new string[5] { "Hammer", "Axe", "Rope", "Duffel bag", "Water bottle",};
        public string Status;

        public Commando(string name, string codeName,string status)
        {
            this.Name = name;
            this.CodeName = codeName;
            this.Status = status;
        }

        public void Walk()
        {
            Console.WriteLine("The commando is walking.");
            Status = "Walking";
        }

        public void Hide()
        {
            Console.WriteLine("The commando is hiding.");
            Status = "Hiding";
        }

        public virtual void Attack()
        {
            Console.WriteLine($"Commando {CodeName} is attacking.");
        }

        public string SayName(string commaderRank)
        {
            return ClearanceHandler.GetName(commaderRank, Name, CodeName);
        }

        

    }
}
