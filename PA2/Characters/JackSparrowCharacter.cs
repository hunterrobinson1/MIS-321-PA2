using System;
using PA2.Interfaces;
using PA2.Attacks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2
{
    public class JackSparrowCharacter : CharacterParentClass
    {
        public JackSparrowCharacter() 
        {
            Name = "Jack Sparrow";
            MaxPower = 65;
            Health = 100;
            AttackStrength = 45;
            DefensivePower = 85; 
            AttackBehavior = new DistractOpponentJS();
            Bio = "Distract";
        }
    }
}