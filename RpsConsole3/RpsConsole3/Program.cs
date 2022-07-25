using System;

namespace RpsConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome message...
            Console.WriteLine("\t\tWelcome to your favorite game!\n\t\tThis is Rock Paper Scissors!\n");

            //Instructions to play... explanation of the game flow. which keys are used, etc
            Console.WriteLine("\tPress the number corresponding to Rock, Paper, or Scissors to make your choice.\n\tThe computer will make its choice and you will be notified as to the winner.\n\nTo play, press enter.\n\n");

            // start the game by pressing ENTER
            Console.ReadLine();

            // (unseen to the user) create some variables to store which choice the user made, 
            // computer choice, computer wins, user wins, number of ties, player1 name (user), player2 name (computer for now)

            int computerChoice = 0;
            Random rand = new Random();// the Random class gets us a pseudorandom decimal between 0 and 1.
            int player1Choice = -1;
            int player1wins = 0;//how many rounds p1 has won
            int computerWins = 0;//how many rounds the compouter has won
            int numberOfTies = 0;//how many ties there have been
            int numberOfGames = 0;

            string player1Name = "";
            int player1NameLength;
            string computerName = "Computer";
            string player1ChoiceStr;
            bool successfulConversion = false;
            bool isTie = true;
            string playAgain = "";

            // get the users name
            Console.WriteLine("What is your name?");
            player1Name = Console.ReadLine();
            player1NameLength = player1Name.Length;

            //user name length function
            while(player1NameLength > 15)
            {
                Console.WriteLine($"Please re-enter a name that is 15 characters or less.");
                player1Name = Console.ReadLine();
                player1NameLength = player1Name.Length;

            }
            
            Console.WriteLine($"Welcome to R-P-S Game, {player1Name}.\nWinning two rounds means you have won a game!\n\t Let's begin!");
        //loop to maintain program
        while(true)
        {
            //this loop is for each beginning of a game.
            while (player1wins<2)
            {


                //a while loop to keep prompting the user for choices till there isn't a tie.
                while (isTie)
                {
                    // get the users choice
                    Console.WriteLine("Please enter...\n\t1 for Rock.\n\t2 for Paper.\n\t3 for Scissors.");
                    player1ChoiceStr = Console.ReadLine();

                    successfulConversion = Int32.TryParse(player1ChoiceStr, out player1Choice);
                    //Console.WriteLine($"the number you inputted was {successfulConversion}, {player1Choice}");


                    // get the computers random choice
                    computerChoice = (rand.Next(1000) % 3) + 1;
                    Console.WriteLine(computerChoice);

                    // evaluate the choices to determine the winner of the round.
                    // if it was a tie
                    if (player1Choice == computerChoice)
                    {
                        // tell them it was a tie and loop back up to the top to reprompt
                        Console.WriteLine($"This round was a tie!... Let's try again.");
                        // update the tally for this gaming session of how many games the computer and the user have won.
                        numberOfTies++;// ++ increments the int by exactly 1.
                        //isTie = true;
                    }
                    // if the user won
                    else if ((player1Choice == 1 && computerChoice == 3) ||
                                (player1Choice == 2 && computerChoice == 1) ||
                                    (player1Choice == 3 && computerChoice == 2))
                    {
                        Console.WriteLine($"Congrats, {player1Name}, you won this round.");
                        // update the tally for this gaming session of how many games the computer and the user have won.
                        player1wins = player1wins + 1;// this method gives you the option of incrementing by more than 1
                                                      // player1wins += 1;
                                                      // player1wins++;
                        isTie = false;
                    }
                    //if the computer won
                    else
                    {// if the computer won
                        Console.WriteLine($"I'm sorry, {computerName} won this round.");
                        // update the tally for this gaming session of how many games the computer and the user have won.
                        computerWins += 1;// this method gives you the option of incrementing by more than 1.
                        isTie = false;
                    }
                }

                // reads counter for player wins and number of games and reset isTie
                isTie=true;
                Console.WriteLine($"You have won {player1wins} rounds");
                Console.WriteLine($"You have played {numberOfGames} games");
               
            }

                //ask to play again, if so, it resets tie loop and playerwin loop and adds to game tally
                Console.WriteLine($"Hey {player1Name}, would you like to play again? \n\t Enter'Y' to play again or 'N' to quit the program.");
                
                playAgain = Console.ReadLine();
                if (String.Equals("Y", playAgain, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"The strings are equal");
                    isTie = true;
                    numberOfGames++;
                    player1wins = 0;
                }
                else
                {
                    //continue;// will end the current loop and immediately start the next iteration of the same loop.
                    Console.WriteLine($"I'm sorry to see you go... ciao.");
                    break;
                }

        }


            // tell the user the tally results as of now.


            // Ask if they want to play again.(keep the tally live till the user wants to quit)



            //quit if they don't want to play... loop up to begin again if they DO want to play again.


        }
    }
}

//REMEMBER TO VALIDATE USER INPUT
// try
// {
//     player1Choice = Int32.Parse(player1ChoiceStr);
// }
// catch (OverflowException ex)
// {
//     //this method to write to the console is string interpolation.
//     Console.WriteLine($"The parse method failed because '{ex.Message}'.");

// }
// catch (FormatException ex)
// {
//     Console.WriteLine($"The parse method failed because {ex.Message}");//this method to write to the console is string interpolation.
// }
// catch (ArgumentNullException ex)
// {
//     Console.WriteLine("The parse method failed because {0}", ex.Message);// This is Composite Formatting.
// }