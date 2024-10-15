using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public class Cryptogram
{
    //Gör en bok som innehåller letråd till pusslet, tex. en av orden i meningen för att kunna lista ut hur pusslet fungerar, om det faktiska order är Hello my friends! så kan boken innehålla: ______ my _____!
    public static void Run()
    {

        System.Console.WriteLine("As you step into the dimly lit room, the heavy wooden door creaks shut behind you, the sound echoing through the cold, damp air. ");
        Console.WriteLine("The only light comes from a faint, flickering glow emanating from the walls, casting eerie shadows on the stone floor.");
        System.Console.WriteLine("Ah, Nice choice meatbag.. " );

        System.Console.WriteLine("system: What would you like to do? for options write Help");
/*
        if (Console.ReadLine() == "Look Around")
        {
            Random random = new Random();
            int randomNumber = random.Next (1, 101);
            System.Console.WriteLine("You look around the room");
            System.Console.WriteLine("To your left, you notice a series of cryptic symbols etched into the wall, the letters twisted and distorted as if written in a madman's hand.");
            System.Console.WriteLine("The words seem to shift and writhe on the surface, like living things.");
            System.Console.WriteLine();
            System.Console.WriteLine("Too your right , a small crooked bookshelf lean against the wall, its wooden shelves bowed under the weight of dusty, leatherbound tomes");
            System.Console.WriteLine();
            if (Console.ReadLine() == "Look Bookshelf")
            {
                System.Console.WriteLine("You walk up to the crooked shelf");
                System.Console.WriteLine("The tomes ");
                
                if ( Console.ReadLine() == "Pick Up Book" ) 
                {
                    System.Console.WriteLine("You pick up the book ");
                    if ( randomNumber >= 50)
                    {
                        System.Console.WriteLine();

                    }
                    else 
                    {

                    }
                    

                }
                

            }
            
        }
        if(Console.ReadLine() == "Look Wall"){
        System.Console.WriteLine("Looking closer you se that it's some kind of writing, words scrambled ");
            System.Console.WriteLine();
            System.Console.WriteLine("System: Would you like to try and read out what it says? if so write Read Word");
        }
        */


        Dictionary<char, char> AtbashCipher = new Dictionary<char, char>()
        {
            { 'A', 'Z' }, { 'B', 'Y' }, { 'C', 'X' }, { 'D', 'W' },
            { 'E', 'V' }, { 'F', 'U' }, { 'G', 'T' }, { 'H', 'S' },
            { 'I', 'R' }, { 'J', 'Q' }, { 'K', 'P' }, { 'L', 'O' },
            { 'M', 'N' }, { 'N', 'M' }, { 'O', 'L' }, { 'P', 'K' },
            { 'Q', 'J' }, { 'R', 'I' }, { 'S', 'H' }, { 'T', 'G' },
            { 'U', 'F' }, { 'V', 'E' }, { 'W', 'D' }, { 'X', 'C' },
            { 'Y', 'B' }, { 'Z', 'A' },
            { 'a', 'z' }, { 'b', 'y' }, { 'c', 'x' }, { 'd', 'w' },
            { 'e', 'v' }, { 'f', 'u' }, { 'g', 't' }, { 'h', 's' },
            { 'i', 'r' }, { 'j', 'q' }, { 'k', 'p' }, { 'l', 'o' },
            { 'm', 'n' }, { 'n', 'm' }, { 'o', 'l' }, { 'p', 'k' },
            { 'q', 'j' }, { 'r', 'i' }, { 's', 'h' }, { 't', 'g' },
            { 'u', 'f' }, { 'v', 'e' }, { 'w', 'd' }, { 'x', 'c' },
            { 'y', 'b' }, { 'z', 'a' },
        };
          
        string originalSentence = "Hello my friends!";

        char[] originalCryptoSentence = new char[originalSentence.Length];
        char[] cryptoSentence = new char[originalSentence.Length];

    

        int i = 0;
         
        
        
        foreach (char c in originalSentence)
        {
            if (char.IsLetter(c))
            {
                char makeUpperChar = char.ToUpper(c);
                if (AtbashCipher.ContainsKey(makeUpperChar))
                {
                    cryptoSentence[i] = AtbashCipher[makeUpperChar];

                    originalCryptoSentence[i] = cryptoSentence[i];

                 
                }
                else
                {
                    cryptoSentence[i] = c;

                    originalCryptoSentence[i] = c;

                   
                }
            }
            else
            {
               cryptoSentence[i] = c;

               originalCryptoSentence[i] = c; 
              
            }
             i++;
       
    
    }
        
        Console.WriteLine("The scrambled letters seem to form some kind of sentence, but what?");
        System.Console.WriteLine();
          
            string str = new string(cryptoSentence);
         System.Console.WriteLine(str);
         if ( Console.ReadLine() == "Solve Chest" ) {
           while(true){

             string playerInput = Console.ReadLine()!;
            
             char playerGuess = char.ToUpper(playerInput[0]);

         for (int j = 0; j < cryptoSentence.Length; j++ )
         {
            if (originalCryptoSentence[j].Equals( AtbashCipher[playerGuess]))
            {
                cryptoSentence[j] = playerGuess;
                Console.WriteLine(cryptoSentence);
            }

            }
            string cryptoStr = new string(cryptoSentence);

            if(cryptoStr.ToUpper() == originalSentence.ToUpper() )
            {
                System.Console.WriteLine("Congrats!");
                break;
            }
         }
            }
            System.Console.WriteLine("As you open the chest you hear a sounds beside you.. *Thonk* a key");
         
    }
}
    

         
         


   












