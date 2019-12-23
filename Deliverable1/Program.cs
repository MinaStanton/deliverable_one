//Mina Stanton
//Program description: This program will inform the user where they should go on vacation based on their inputs.


using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            String vacationType, result, destinationType = " ", travelMode = " ";
            int groupSize;
            
            Console.WriteLine("Hello and welcome to travel assist!" + "\n"); //greeting the user
            Console.WriteLine("I am going to ask you a couple of questions to help you decide your next vacation. Let's get started!" +"\n"); //letting the user know what is to be expected
            Console.WriteLine("Would you like to go on a Musical, Tropical, or Adventurous type of trip?"); //user will choose between 3 types of vacations
            vacationType = Console.ReadLine(); //storing user input into the variable vacationType
            vacationType = vacationType.ToLower(); //converting user input to lowercase in order to compare regardless if the user inputs the name in upper or lowercase
            

            Console.WriteLine("How many travellers?"); 
            groupSize = int.Parse(Console.ReadLine()); 

            if(vacationType == "musical") //utilizing if-else statements to determine the type of vacation destination 
            {
                destinationType = "go to New Orleans";
            }
            else if (vacationType == "tropical")
            {
                destinationType = "go to a beach vacation in Mexico";
            }
            else if (vacationType == "adventurous")
            {
                destinationType = "go whitewater rafting in the Grand Canyon";
            }
           

            if (groupSize >= 6) //utilizing if-else statements to determine the travel mode suggestion
            {
                travelMode = "charter flight";
            }
            else if(groupSize >= 3)
            {
                travelMode = "helicopter";
            }
            else if(groupSize >= 1)
            {
                travelMode = "first class";
            }
           
            //utilizing concatenation for the variable result
            result = "You have " + groupSize + " travelling and the vacation should be " + vacationType + ", based on the criteria you entered you should " + destinationType + " via " + travelMode + ". ";

            Console.WriteLine("\n" + result); //output the result to console

        }
    }
}
