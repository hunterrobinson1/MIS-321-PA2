using System;
using PA2.Interfaces;
using PA2.Attacks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2
{
    public class JackSparrowCharacter : CharacterParentClass //inherits properties of CharacterParentClass. This is where I set them 
    {
        public JackSparrowCharacter() 
        {
            Name = "Jack Sparrow";
            MaxPower = 65;
            Health = 100;
            AttackStrength = 45;
            DefensivePower = 85; 
            AttackBehavior = new DistractOpponentJS(); //new attack behavior
            Bio = "Distract"; //bio displays their weapon, looks better like this on the display
        }
    }
}