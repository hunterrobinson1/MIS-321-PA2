using System;
using System.IO;
using PA2.Attacks;
using PA2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2
{
    public class DavyJonesCharacter : CharacterParentClass //inherits properties of CharacterParentClass. This is where I set them 
    {
        public DavyJonesCharacter() 
        {
            Name = "Davy Jones";
            MaxPower = 95;
            Health = 100;
            AttackStrength = 85;
            DefensivePower = 45;
            AttackBehavior = new CannonFireDJ(); //new attack behavior
            Bio = "Cannon fire"; //bio displays their weapon, looks better like this on the display
        }

    }
}