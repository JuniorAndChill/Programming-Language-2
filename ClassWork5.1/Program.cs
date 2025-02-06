/* Daniel Critchlow Jr*/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1) Write a program that receives the game results of three basketball teams in a 2D array. 
            Games won receive a point, games lost receive no points. The program should determine which 
            team is the winner (most games won). There will be no ties.

            Input: There is no input from the keyboard, but copy this array into the code
            int[,] gamesWon = { {1, 0, 0, 0, 0, 1}, {1, 1, 1, 0, 0, 1} , {0, 0, 1, 0, 1, 1}};

            Output:    The second team has wins*/
            
            int [,] gamesWon = { {1, 0, 0, 0, 0, 1}, {1, 1, 1, 0, 0, 1} , {0, 0, 1, 0, 1, 1}};
            
            //i use GetLength to index the arrays
            int nTeams = gamesWon.GetLength(0); //finds number of teams
            int nGames = gamesWon.GetLength(1); //finds wins from arr

            //store the findings in new array for comparison later
            int [] Scores = new int[nTeams];

            //nested loop to compare teams playing to wins made
            for(int i = 0; i < nTeams; i++)
            {
                for(int j = 0; j < nGames; j++)
                {
                    //this updates wins against teams who did it
                    Scores[i] += gamesWon[i, j];
                }
            }

            //initialize counter for who won most
            int winner = 0;
            for(int i = 1; i < nTeams; i++)
            {
                //if arguement to figure out the winner
                if(Scores[i] > Scores[winner])
                {
                    //store the winner by team index value
                    winner = i;
                }
            }

            //display winner+1 because index starts from 0 in arrays
            Console.Write("\nTeam #" + (winner+1) + " has the most wins");
        }
    }
}