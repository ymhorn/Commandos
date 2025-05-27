using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Weapon
    {
        public string Name;
        public string Manufacturer;
        public int NumberOfBullets;

        public Weapon(string name, string manufacturer, int numberOfBullets)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.NumberOfBullets = numberOfBullets;
        }

        public void Shoot()
        {
            Console.WriteLine("Shot bullet");
            NumberOfBullets--;
        }
    }
}
