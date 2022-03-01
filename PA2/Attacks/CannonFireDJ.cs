using System;
using PA2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2.Attacks
{
    public class CannonFireDJ :IAttack //inherits IAttack
    {
        public void Attack()
        {
            System.Console.WriteLine( "Just bombarded you with cannon fire");
        }
    }
}