using RockPaperScissorsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsApp.Core
{
    public class GameLogic
    {
        /// <summary>
        /// Gets the computer action using a random function
        /// </summary>
        /// <returns></returns>
        public static GameAction GetComputerAction()
        {
            Random rnd = new Random();
            GameAction result = (GameAction)rnd.Next(0, 2);

            return result;
        }
        /// <summary>
        /// Determines the outcome of the game for the player.
        /// </summary>
        /// <param name="computerAction">The computer action.</param>
        /// <param name="playerAction">The player action.</param>
        /// <returns></returns>
        public static GameResult DetermineOutcome(GameAction computerAction, GameAction playerAction)
        {
            GameResult result = GameResult.Draw;
            switch (playerAction) 
            {
                case GameAction.Rock:
                    if (computerAction == GameAction.Paper)
                        result = GameResult.Lose;
                    if (computerAction == GameAction.Scissors)
                        result = GameResult.Win;
                    break;
                case GameAction.Paper:
                    if (computerAction == GameAction.Scissors)
                        result = GameResult.Lose;
                    if (computerAction == GameAction.Rock)
                        result = GameResult.Win;
                    break;
                case GameAction.Scissors:
                    if(computerAction == GameAction.Rock)
                        result = GameResult.Lose;
                    if (computerAction == GameAction.Paper)
                        result = GameResult.Win;
                    break;
            }
            return result;
        }
    }
}