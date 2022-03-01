using System;
using System.IO;
using PA2.Interfaces;
using PA2.Attacks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PA2
{
    public class PlayersParentClass
    {
        public string Name {get;set;} //gets the name 
        public CharacterParentClass PlayerSelection{get;set;} //gets the character 

        public static PlayersParentClass[] players = {new PlayersParentClass(), new PlayersParentClass()}; //player array 
        
        public PlayersParentClass() //constructor
        {
            Name = GetPlayerName();
            PlayerSelection = GetPlayerChar();
        }

        public static string GetPlayerName() //methods that get called when creating a new player. Gets their name 
        {
            System.Console.WriteLine("");
            System.Console.Write("Please enter player name: ");
            string NameOne = Console.ReadLine();
            System.Console.WriteLine("Player name: " + NameOne);


            return NameOne; 
        }


        public CharacterParentClass GetPlayerChar() //methods that get called when creating a new player. Get their character
        {
            Displays.DisplayCharacters();
            string userInput = Console.ReadLine();
            if(userInput == "1")
            {
                PlayerSelection = new DavyJonesCharacter();
                System.Console.WriteLine("Davy Jones");
                
            }
            else if(userInput == "2")
            {
                PlayerSelection = new JackSparrowCharacter();
                System.Console.WriteLine("Jack Sparrow");
            }
            else if(userInput =="3")
            {
                PlayerSelection = new WillTurnerCharacter();
                System.Console.WriteLine("Will Turner");
            }
            else
            {
                System.Console.WriteLine("You've made an incorrect selection. Please try again.");
                System.Console.WriteLine("Hit any [KEY] to continue....");
                System.Console.ReadKey();
                System.Console.Clear(); 
                GetPlayerChar(); 
            }

            return PlayerSelection;

        } 
        

    }



}