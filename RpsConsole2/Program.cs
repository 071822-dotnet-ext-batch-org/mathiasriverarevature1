using System;

namespace RpsConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message with new line symbol '\n'
            Console.WriteLine("\t\tWelcome to Rock Paper Scissors!\n\t\tWoop Woop!\n\n");


            //Instructions to play...explain the game flow. Whick keys used etc.
            Console.WriteLine("\t Press the number corresponding to Rock, Paper, or Scissors to make your choice.\n\t The computer will make its choice and you will be notified of the winner.\n\nTo play, press enter.\n");


            //Start the game by pressing ENTER
            Console.ReadLine();


            //(unseen to user) create variables to store the use made
            //computer choice, com wins, user wins, ties, player1(user), player2(com)
            
            int computerChoice = 0;
            Random rand = new Random(); //the Random class gets us a pseudorandom decimal between 0 and 1
            int myrandomnum = rand.Next();
            int player1Choice = 0;
            int player1wins = 0;
            int computerWins = 0;
            int numberOfTies = 0;
            string player1Name = "";
            string computerName = "";
            string player1ChoiceStr;
            bool successfulConversion = false;
            bool isTie = true;
            string playAgain;


            //get the users name

            Console.WriteLine("What is your name?");
            player1Name = Console.ReadLine();
            Console.WriteLine($"Welcome to R-P-S Game, {player1Name}");

            //this loop is for each beginning of a game
            while(true)
            {

            //a while loop to keep prompting the user for choices until there isnt a tie
            while(isTie)
            {
            //get the users choice
            Console.WriteLine("Please enter...\n\t1 for Rock.\n\t2 for Paper\n\t3 for Scissor.");
            player1ChoiceStr = Console.ReadLine();

            //REMEMBER TO VALIDATE USER INPUT
            //two ways to validate user input: try catch and tryparse
           /** try{
                 player1ChoiceStr = Int32.Parse(player1ChoiceStr);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine($"The parse method failed because {player1Choice}, {ex.Message}");//interpolation
                Console.WriteLine("The parse method failed because {1},{0},{2}",ex.Message,player1ChoiceStr,player1Name);//the way to do it with an array-like structure. called Composite structure
            }   
            catch(FormatException ex)
            {
                Console.WriteLine($"The parse method failed because {player1Choice}, {ex.Message}");

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine($"The parse method failed because {player1Choice}, {ex.Message}");

            }  */
            
            successfulConversion = Int32.TryParse(player1ChoiceStr, out player1Choice);
            //Console.WriteLine($"the number you inputted was {successfulConversion},{player1Choice}");

            //get the computers RANDOM choice
            computerChoice = (rand.Next(1000)%3)+1; //rand.Next(3)+1; could also work but with less of a chance of a 1 due to computation
            Console.WriteLine(computerChoice);


            //evaluate the choices to determine the winner of the round
            //tie
            if(player1Choice == computerChoice){
                Console.WriteLine("It was a tie. Let's try again.");
                //update tie tally
                numberOfTies++; //increments int by exactly 1
                
                //loop back up
            }
             //if user won
            else if((player1Choice == 1 && computerChoice == 3) || 
                     (player1Choice == 2 && computerChoice ==1) ||
                        (player1Choice == 3 && computerChoice == 2))
            {
                Console.WriteLine($"Congratulations, {player1Name}, you won this round.");
                //update user tally
                player1wins = player1wins + 1; //this method gives you option of adjusting increment
                isTie = false;
            }
            //if computer won
            else
            {
                Console.WriteLine($"I'm sorry, {computerName} won this round");
                //update computer tally
                computerWins += 1; //this method gives you option of adjusting increment
                isTie=false;
            }
       
              }

            //ask if they want to play again (is using rounds each game would need to be stored)
            Console.WriteLine($"Hey {player1Name}, would you like to play again?/n/t 'Y' to play again or 'N' to quit the program.");
            playAgain = Console.ReadLine();
            if(String.Equals("Y", playAgain, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"the strings are equal");
                isTie = true;
            }
           else{
                //continue;//will end the current loop and immediately start the next iteration
                Console.WriteLine($"Sorry to see you go, ciao");
                break;//breaks out of current loop and the rest of the loop is left unexecuted
            }

        }

            
            
            
            //tell the user the tally results as of now.


            //Ask if they want to play again (keep tally live until user quits) 



            //quit if they dont want to play...loop up to begin gain if they DO want to play again















        }
    }
}
