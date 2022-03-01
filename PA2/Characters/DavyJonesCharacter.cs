using System;
using System.IO;
using PA2.Attacks;
using PA2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2
{
    public class DavyJonesCharacter : CharacterParentClass
    {
        public DavyJonesCharacter() 
        {
            Name = "Davy Jones";
            MaxPower = 95;
            Health = 100;
            AttackStrength = 85;
            DefensivePower = 45;
            AttackBehavior = new CannonFireDJ();
            Bio = "Cannon fire";
        }

    }
}