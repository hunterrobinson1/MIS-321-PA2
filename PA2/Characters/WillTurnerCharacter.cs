using System;
using PA2.Interfaces;
using PA2.Attacks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2
{
    public class WillTurnerCharacter: CharacterParentClass
    {
        public WillTurnerCharacter() 
        {
            Name = "Will Turner";
            MaxPower = 75;
            Health = 100 ;
            AttackStrength = 90;
            DefensivePower = 35; 
            AttackBehavior = new SwordWT();
            Bio = "Sword";
        }
    }
}