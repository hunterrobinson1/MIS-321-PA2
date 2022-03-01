using System;
using System.IO;
using PA2.Interfaces;
using PA2.Attacks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2
{
    public class Game 
    {

        public Game()
        {
            PlayersParentClass PlayerOne = new PlayersParentClass(); //new player object
            PlayersParentClass PlayerTwo = new PlayersParentClass(); //new player object
        }
        public static void LetsPlay() //Game itself
        {
            System.Console.Clear(); 
            System.Console.WriteLine("Welcome to the Maelstrom.....");
            System.Console.WriteLine("This game mode consist of two players.");
            System.Console.WriteLine("Enter your name and select the character you wish to play with when prompted!");
            System.Console.WriteLine("");
            System.Console.WriteLine("Hit any [KEY] to continue....");
            System.Console.ReadKey();
            System.Console.Clear();
            PlayersParentClass PlayerOne = new PlayersParentClass(); //declaring the new players. Gets their names and their character selection
            PlayersParentClass PlayerTwo = new PlayersParentClass(); //declaring the new players. Gets their names and their character selection
            System.Console.WriteLine("Both players have entered their info.");
            System.Console.WriteLine("Hit any [KEY] to continue....");
            System.Console.ReadKey();
            System.Console.Clear();
            System.Console.ForegroundColor = ConsoleColor.Blue;
            System.Console.WriteLine("Player ones name is: " + PlayerOne.Name); //player ones name 
            System.Console.WriteLine("Player ones character is: " + PlayerOne.PlayerSelection.Name); //their selection
            System.Console.ResetColor();
            Console.WriteLine("()--()--()--()--()--()--()--()--()--()--()--()--()--()--()-()--()");
            System.Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("Player twos name is: " + PlayerTwo.Name); //player two name 
            System.Console.WriteLine("Player twos character is: " + PlayerTwo.PlayerSelection.Name); //their selection
            System.Console.ResetColor();
            Console.WriteLine("()--()--()--()--()--()--()--()--()--()--()--()--()--()--()-()--()");
            System.Console.WriteLine("");
            System.Console.WriteLine("Hit any [KEY] to continue....");
            System.Console.ReadKey();
            System.Console.Clear();

            
            System.Console.WriteLine("First we will flip a coin. If it lands heads " + PlayerOne.Name + " goes first. If it lands tails then " + PlayerTwo.Name + " goes first.");
            System.Console.WriteLine("Hit any [KEY] to continue....");
            System.Console.ReadKey();
            System.Console.Clear();
            Random coinFlip = new Random(); //Coimn flip that goes into an if and an else if depending on if it lands heads or tails
            int number = coinFlip.Next(1,3);

            if(number ==1) //if player one goes first
            {
                System.Console.WriteLine("The coin landed heads! " + PlayerOne.Name + " will attack first!"); //lands heads player one attacks first
                System.Console.WriteLine("Hit any [KEY] to continue....");
                System.Console.ReadKey();
                System.Console.Clear();

                double bonus;  //all the scenarios with the bonus 
                if(PlayerOne.PlayerSelection.Name == "Jack Sparrow" && PlayerTwo.PlayerSelection.Name == "Will Turner")
                {
                    System.Console.WriteLine("Jack Sparrows attack bonus has been activated... Good luck Will Turner!");
                    bonus = PlayerOne.PlayerSelection.MaxPower * 1.2;
                    
                }
                else if(PlayerOne.PlayerSelection.Name == "Will Turner" && PlayerTwo.PlayerSelection.Name == "Davy Jones")
                {
                    System.Console.WriteLine("Will Turners attack bonus has been activated... Good luck Davy Jones!");
                    bonus = PlayerOne.PlayerSelection.MaxPower * 1.2;
                }
                else if(PlayerOne.PlayerSelection.Name == "Davy Jones" && PlayerTwo.PlayerSelection.Name == "Jack Sparrow")
                {
                    System.Console.WriteLine("Davy Jones attack bonus has been activated... Good luck Jack Sparrow!");
                    bonus = PlayerOne.PlayerSelection.MaxPower * 1.2; 
                }
                else
                {
                    bonus = PlayerOne.PlayerSelection.MaxPower * 1;
                }
                
                while(PlayerOne.PlayerSelection.Health > 0|| PlayerTwo.PlayerSelection.Health > 0)
                {
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    int attack = AttackDamageGenerator();
                    System.Console.WriteLine(PlayerOne.Name + " health is at: " + PlayerOne.PlayerSelection.Health); //shows health
                    System.Console.WriteLine("");
                    System.Console.WriteLine( PlayerOne.Name + " power level is at: " + PlayerOne.PlayerSelection.MaxPower); //shows max power
                    System.Console.WriteLine("");
                    System.Console.WriteLine(PlayerOne.Name + " has attacked and has used " + PlayerOne.PlayerSelection.Bio); //shows how theyve been attacked
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Damage inflicted: " + attack + " to " + PlayerTwo.Name); //shows damage inflicted
                    System.Console.WriteLine("");
                    PlayerTwo.PlayerSelection.Health = PlayerTwo.PlayerSelection.Health - attack; //sets their health
                    System.Console.WriteLine(PlayerTwo.Name + " now has " + PlayerTwo.PlayerSelection.Health + " health"); //displayes their health after the attack 
                    System.Console.WriteLine("");
                    System.Console.ResetColor();
                    if(PlayerTwo.PlayerSelection.Health <= 0) //checks if player health is less than one 
                    {
                        System.Console.ForegroundColor = ConsoleColor.Blue; //if true then you can return to the main menu and play again
                        System.Console.WriteLine(PlayerOne.Name + " has won the game!");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("If you wish to play again hit any [KEY] to return to the main menu.");
                        System.Console.ResetColor();
                        System.Console.ReadKey();
                        System.Console.Clear();
                        Displays.Selection();
                        break;
                    }
                    System.Console.WriteLine("Hit any [KEY] to continue to the next round");
                    System.Console.ReadKey();
                    System.Console.Clear();
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    int attackTwo = AttackDamageGenerator();
                    System.Console.WriteLine(PlayerTwo.Name + " health is at: " + PlayerTwo.PlayerSelection.Health); //displays the health
                    System.Console.WriteLine("");
                    System.Console.WriteLine(PlayerTwo.Name + " has attacked and has used " + PlayerTwo.PlayerSelection.Bio); //dispays the attack 
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Damage inflicted: " + attackTwo + " to " + PlayerOne.Name); //displays damage inflicted 
                    System.Console.WriteLine("");
                    PlayerOne.PlayerSelection.Health = PlayerOne.PlayerSelection.Health - attackTwo; //math for their health
                    System.Console.WriteLine(PlayerOne.Name + " now has " + PlayerOne.PlayerSelection.Health + " health"); //displays their health after the attack
                    System.Console.ResetColor();
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Hit any [KEY] to continue to the next round");
                    System.Console.ReadKey();
                    System.Console.Clear();
                    if(PlayerOne.PlayerSelection.Health <= 0) //checks if player health is less than one 
                    {
                        System.Console.ForegroundColor = ConsoleColor.Red; //if true then you can return to the main menu and play again
                        System.Console.WriteLine(PlayerTwo.Name + " has won the game!");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("If you wish to play again hit any [KEY] to return to the main menu.");
                        System.Console.WriteLine("");
                        System.Console.ResetColor();
                        System.Console.ReadKey();
                        System.Console.Clear();
                        Displays.Selection();
                        break; 
                    }
                    
                }
                
            }
            else if(number == 2) //if player 2 goes first 
            {
                System.Console.WriteLine("The coin landed tails! " + PlayerTwo.Name + " will attack first"); //player two attacks first if tails
                System.Console.WriteLine("Hit any [KEY] to continue....");
                System.Console.ReadKey();
                System.Console.Clear();
                double bonus;
                if(PlayerTwo.PlayerSelection.Name == "Jack Sparrow" && PlayerOne.PlayerSelection.Name == "Will Turner") //all the scenarios for the bonus
                {
                    System.Console.WriteLine("Jack Sparrows attack bonus has been activated... Good luck Will Turner!");
                    bonus = PlayerTwo.PlayerSelection.MaxPower * 1.2;
                }
                else if(PlayerTwo.PlayerSelection.Name == "Will Turner" && PlayerOne.PlayerSelection.Name == "Davy Jones")
                {
                    System.Console.WriteLine("Will Turners attack bonus has been activated... Good luck Davy Jones!");
                    bonus = PlayerTwo.PlayerSelection.MaxPower * 1.2;
                }
                else if(PlayerTwo.PlayerSelection.Name == "Davy Jones" && PlayerOne.PlayerSelection.Name == "Jack Sparrow")
                {
                    System.Console.WriteLine("Davy Jones attack bonus has been activated... Good luck Jack Sparrow!");
                    bonus = PlayerTwo.PlayerSelection.MaxPower * 1.2;
                }
                else
                {
                    bonus = PlayerTwo.PlayerSelection.MaxPower * 1;
                } 

                while(PlayerOne.PlayerSelection.Health > 0|| PlayerTwo.PlayerSelection.Health > 0) //game itself
                {
                    System.Console.ForegroundColor = ConsoleColor.Red;
                    System.Console.WriteLine(PlayerTwo.Name + " health is at: " + PlayerTwo.PlayerSelection.Health); //displays health 
                    System.Console.WriteLine("");
                    System.Console.WriteLine( PlayerTwo.Name + " power level is at: " + PlayerTwo.PlayerSelection.MaxPower); //displays power level 
                    int attack = AttackDamageGenerator();
                    System.Console.WriteLine("");
                    System.Console.WriteLine(PlayerTwo.Name + " has attacked and has used " + PlayerTwo.PlayerSelection.Bio); //displays the attack 
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Damage inflicted: " + attack + " to " + PlayerOne.Name); //displays damage inflicted
                    System.Console.WriteLine("");
                    PlayerOne.PlayerSelection.Health = PlayerOne.PlayerSelection.Health- attack; //math for the turn
                    System.Console.WriteLine(PlayerOne.Name + " now has " + PlayerOne.PlayerSelection.Health + " health"); //displays health after the attack 
                    System.Console.WriteLine("");
                    System.Console.ResetColor();
                    if(PlayerOne.PlayerSelection.Health <= 0) //checks the players health and if its 0 then the games over
                    {
                        System.Console.ForegroundColor = ConsoleColor.Red; //if true then you can return to the main menu and play again
                        System.Console.WriteLine(PlayerTwo.Name + " has won the game!");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("If you wish to play again hit any [KEY] to return to the main menu.");
                        System.Console.ResetColor();
                        System.Console.ReadKey();
                        System.Console.Clear();
                        Displays.Selection();
                        break;  
                    }
                    System.Console.WriteLine("Hit any [KEY] to continue to the next round");
                    System.Console.ReadKey();
                    System.Console.Clear();
                    System.Console.ForegroundColor = ConsoleColor.Blue;
                    int attackTwo = AttackDamageGenerator();
                    System.Console.WriteLine(PlayerOne.Name + " health is at: " + PlayerOne.PlayerSelection.Health); //Displays the health
                    System.Console.WriteLine("");
                    System.Console.WriteLine(PlayerOne.Name + " has attacked and has used " + PlayerOne.PlayerSelection.Bio); //displays the attack 
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Damage inflicted: " + attackTwo + " to " + PlayerTwo.Name); //damage inflicted after attack 
                    System.Console.WriteLine("");
                    PlayerTwo.PlayerSelection.Health = PlayerTwo.PlayerSelection.Health - attackTwo; //math for the attack 
                    System.Console.WriteLine(PlayerTwo.Name + " now has " + PlayerTwo.PlayerSelection.Health + " Health"); //displays health aftet the attack 
                    System.Console.ResetColor();
                    System.Console.WriteLine("");
                    System.Console.WriteLine("Hit any [KEY] to continue to the next round");
                    System.Console.ReadKey();
                    System.Console.Clear();
                    if(PlayerTwo.PlayerSelection.Health <= 0) //checks the players health and if its 0 then the games over
                    {
                        System.Console.ForegroundColor = ConsoleColor.Blue; //if true then you can return to the main menu and play againd
                        System.Console.WriteLine(PlayerOne.Name + " has won the game!");
                        System.Console.WriteLine("");
                        System.Console.WriteLine("If you wish to play again hit any [KEY] to return to the main menu.");
                        System.Console.ResetColor();
                        System.Console.ReadKey();
                        System.Console.Clear();
                        Displays.Selection();
                        break;  
                    } 
                    
                }
            }
              
        }

        public static int AttackDamageGenerator() //attack damage generator 
        {
            Random r = new Random();
            int attackDamage = r.Next(1,100);
            return attackDamage;
        }
    }
}