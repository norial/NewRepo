using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    internal class Rifle : Weapon
    {
        public override void Attack()
        {
            Console.WriteLine("You attacked with rifle");
        }
    }
}
