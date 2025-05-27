using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commandos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando Neriya = new Commando("Neriya", "X","Standing");
            Weapon M16 = new Weapon("Heater", "Colt's Manufacturing Company", 30);
            Console.WriteLine(Neriya.Name +" "+ Neriya.CodeName + " " +Neriya.Status);
            Console.WriteLine(M16.Name + " " +M16.Manufacturer + " " +M16.NumberOfBullets);
            Console.WriteLine(Neriya.Utensils[3]);
            Neriya.Walk();
            Console.WriteLine(Neriya.Status);
            Neriya.Hide();
            Console.WriteLine(Neriya.Status);
            Neriya.Attack();
            M16.Shoot();
            Console.WriteLine(M16.NumberOfBullets);
        }
    }
}
