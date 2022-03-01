using System;
using System.IO;
using PA2.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2
{
    public class CharacterParentClass //character parent class all the others inherit from 
    {
        public string Name{get;set;}
        public int MaxPower{get;set;}
        public int Health{get;set;}
        public int AttackStrength{get;set;}
        public int DefensivePower{get;set;}
        public string Bio{get;set;}

        public IAttack AttackBehavior {get;set;}

        public static CharacterParentClass[] characters = {new DavyJonesCharacter(), new JackSparrowCharacter(), new WillTurnerCharacter()}; //array of the characters

        public static CharacterParentClass[] Characters()
        {
            return characters; //returns the list of characters
        }

    }
}