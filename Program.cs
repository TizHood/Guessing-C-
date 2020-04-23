using System.Net.Http.Headers;
using System.ComponentModel.Design.Serialization;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Data.Common;
using System.Runtime.Serialization.Json;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Reflection.Metadata;
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;
using System.Reflection.Emit;
using System.Data;
using System;
using System.Collections.Generic;
namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int firstLevel = random.Next(1,11);
            int secondLevel = random.Next(1,21);
            int thirdLevel = random.Next(1,51);
            bool gameOver = false;
            bool timeOut = false;
            bool downTime = false;

            
            string myName = "";
            Console.Write("What is your name: ");
            myName = Console.ReadLine();
            Console.WriteLine("Hello " + myName);
            string difficulty = "";
            Console.Write("Well, " + myName + ". What difficulty would you like? easy medium or hard? ");
            difficulty = Console.ReadLine();
            Console.WriteLine("You have selected " + difficulty + " level. Enjoy!!!"); 

            //LEVEL IS EASY 
            if (difficulty == "easy") {
                Console.WriteLine ("Okay, " + myName + ". I am thinking of a number between 1 and 10");
            

            int guess = 0;
            int numberofGuesses = 6;
            
            while (gameOver == false){
                guess = int.Parse(Console.ReadLine());
                numberofGuesses--;
                int chances = 6 - numberofGuesses;

                if (guess != firstLevel){
                    Console.WriteLine("That was wrong " + myName + ". Try again");
                    Console.WriteLine(myName + ", you have " + numberofGuesses + " guesses left.");
                    
                }
                if (numberofGuesses == 0){
                    Console.WriteLine("Game over " + myName + ". You lost!!!");
                    Console.WriteLine("The number I was thinking of is " + firstLevel);      
                    gameOver = true;
                }
                else if (guess == firstLevel){
                    Console.WriteLine("You got it right, " + myName + "! You guessed my number in " + chances +  " guesses!");
                    gameOver = true;
                }
            }
            }
                //LEVEL IS MEDIUM 
            if (difficulty == "medium") {
                Console.WriteLine ("Okay, " + myName + ". I am thinking of a number between 1 and 20");
            

            int guesss = 0;
            int guesssTaken = 4;
            
            while (timeOut == false){
                guesss = int.Parse(Console.ReadLine());
                guesssTaken--;
                int period = 4 - guesssTaken;

                if (guesss != secondLevel){
                    Console.WriteLine("That was wrong " + myName + ". Try again");
                    Console.WriteLine(myName + ", you have " + guesssTaken + " guesses left.");
                    
                }
                if (guesssTaken == 0){
                    Console.WriteLine("Game over " + myName + ". You lost!!!");
                    Console.WriteLine("The number I was thinking of is " + secondLevel);      
                    timeOut = true;
                }
                else if (guesss == secondLevel){
                    Console.WriteLine("You got it right, " + myName + "! You guessed my number in " + period +  " guesses!");
                    timeOut = true;
                }
            }
            }
//LEVEL IS HARD 
            if (difficulty == "hard") {
                Console.WriteLine ("Okay, " + myName + ". I am thinking of a number between 1 and 50");
            

            int guessed = 0;
            int guessedAmount = 3;
            
            while (downTime == false){
                guessed = int.Parse(Console.ReadLine());
                guessedAmount--;
                int times = 3 - guessedAmount;

                if (guessed != thirdLevel){
                    Console.WriteLine("That was wrong " + myName + ". Try again");
                    Console.WriteLine(myName + ", you have " + guessedAmount + " guesses left.");
                    
                }
                if (guessedAmount == 0){
                    Console.WriteLine("Game over " + myName + ". You lost!!!");
                    Console.WriteLine("The number I was thinking of is " + thirdLevel);      
                    downTime = true;
                }
                else if (guessed == thirdLevel){
                    Console.WriteLine("You got it right, " + myName + "! You guessed my number in " + times +  " guesses!");
                    downTime = true;
                }
            }
            }
        Console.WriteLine("Thank you for playing this game");
        }
          
    }
}

            

