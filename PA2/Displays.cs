using System;
using System.IO;
using PA2.Interfaces;
using PA2.Attacks;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PA2
{
    public class Displays
    {
        public static void DisplayCharacters() //displays the characters to choose from 
        {
            CharacterParentClass [] characters = CharacterParentClass.Characters();
            for(int i = 0; i< characters.Length; i++)
            {
                System.Console.WriteLine($"#{i+1}| Name: {characters[i].Name} | Max Power: {characters[i].MaxPower} | Health: {characters[i].Health} | Attack Strength: {characters[i].DefensivePower} | Attack Behavior: {characters[i].Bio}");
            }
            System.Console.WriteLine(" ");
            System.Console.Write("Please enter the number of the character you wish to play with: ");
            //if u wanna display attack do bio

        }

        public static void ReturnMainMenu() //when called returns you to the main menu
        {
            System.Console.WriteLine("Hit any [KEY] to return to the main menu");
            System.Console.Clear();
            Selection();
        }

        public static void MainMenu() //main menu display
        {
            Console.Clear();
            Console.WriteLine("Welcome to Pirates of the Carribean! Please select one of the following options:");
            Console.WriteLine("()--()--()--()--()--()--()--()--()--()--()--()--()--()--()-()--()--()--()--()--()");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.WriteLine("1) Join the fight !");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("2) Exit");
        }

        public static void Selection() //selection calls the main menu and then switch statements run
        {
            MainMenu();
            switch (Console.ReadLine())
            {
                
                case "1":
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You've selected to fight! Here you'll be able to duel against opponents and claim victory!");
                System.Console.WriteLine("()--()--()--()--()--()--()--()--()--()--()--()--()--()--()-()--()--()--()--()--()");
                Console.WriteLine("Hit any [KEY] to see the instructions...");
                Console.ReadKey(); 
                Game.LetsPlay(); //selecting option one takes you to the game
                
                break;

                case "2":
                Console.ReadKey();
                Console.Clear();
                System.Environment.Exit(2); //selection option two will exit you
                break;

                default:
                Console.ReadKey();
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You've made the wrong selection. Please try again. "); //default if you select anything other than the 4 option
                Console.WriteLine("Hit any [KEY] to continue...");
                Console.ReadKey();
                Console.ResetColor();
                Displays.ReturnMainMenu();
                break;
            }
        }

        
    }
}