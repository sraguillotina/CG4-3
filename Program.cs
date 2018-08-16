using System;

namespace Practice_randomization
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Create a program that asks the user to enter up to 30 names and stores them in an array. 
             * If the user hits enter without entering a name, assume they are done and stop asking them. 
             * Then, you will randomly choose a name from the array and write it to the console as 
             * the winner. Then, you will write the list of other names that did not win. 
             * Upload your program to a new repository called CG 4-3*/

            Console.WriteLine("This is a raffle game. \nEnter up to 30 names " +
                "and I will select a random winner from your entries. \nEnter names: ");

            //This initialized a new array called entryNames, which can hold the 30 names/entries.
            string[] entryNames = new string[30];

            //I have declared a "counter" variable so that my randomized array will only select/
            //go up to number of values entered by the user. The counter starts at 0.
            var counter = 0;
            
            //for loop is used in order to go through each value/entry entered by the user, looping
            //through thirty possible entries.
            for (int i = 0; i < 30; i++)
            {
                //The user's input entry is assigned a value "i" in the array. (This is an integer value.)
                entryNames[i] = Console.ReadLine();
                
                //In order to break out of the loop if the user doesn't enter a name and only presses
                //the Enter key (leaves entry blank), I create condition where blank ("") is evaluated for entryNames[i] value.
               
                if (entryNames[i] == "")
                {
                    //break will stop/break out of loop and continue to next block of code.
                    break;
                }
                
                //This statement affects the counter variable, so that each time my application
                //goes through the loop code block, it adds one value to the counter variable.
                //The counter variable value started at zero.
                counter++;
            }
            
            //Initialized a new random class in order to randomize user input entries.
            Random randomizedNames = new Random();
            //The random name selection (using the new randomizedNames random class) is assigned to
            //the string result. The random name is chosen using Next helper method that will
            //return a single value from the range of values from 0 to the counter's upper value limit.
            string result = entryNames[randomizedNames.Next(0, counter)];
            Console.WriteLine($"{result} is the winner!");

            //To provide a line space
            Console.WriteLine();

            Console.WriteLine("Sorry, you did not win today: ");

            //To provide a line space
            Console.WriteLine();

            //Initialized in-line loop to create list of names not chosen.
            for (int i = 0; i < entryNames.Length; i++)
            {
                //Condition to omit user's blank entries. break will
                //exit loop. This stops the iteration because we know 
                //there were no more entries after a blank since the prior loop was exited
                //once the user entered a "".
                if (entryNames[i] == "")
                {
                    break; 
                }

                //I want to skip result string, and break the loop.
                else if (entryNames[i] == result)
                {
                    continue;
                }

                /*Prints those values from the entryNames array not excluded by the
                prior if conditions in this loop.
                (foreach loop can also be used instead of for loop.)*/
                Console.WriteLine(entryNames[i]);
                
            }
            
            Console.ReadLine();
            
        }
    }
}
