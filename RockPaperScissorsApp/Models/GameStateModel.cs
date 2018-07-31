using RockPaperScissorsApp.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RockPaperScissorsApp.Models
{
    public class VMGameState
    {
        private GameAction ComputerAction;
        private GameAction PlayerAction;
        private GameResult Result;

        /// <summary>
        /// Initializes a new instance of the <see cref="VMGameState"/> class.
        /// </summary>
        /// <param name="playerAction">The player action.</param>
        /// <param name="computerAction">The computer action.</param>
        /// <param name="result">The result.</param>
        public VMGameState(GameAction playerAction, GameAction computerAction, GameResult result)
        {
            ComputerAction = computerAction;
            PlayerAction = playerAction;

            Result = result;
        }

        /// <summary>
        /// Gets the outcome of the game.
        /// </summary>
        /// <returns></returns>
        public GameResult GetOutcome()
        {
            return Result;
        }

        /// <summary>
        /// Gets the computer action as a string.
        /// </summary>
        /// <returns></returns>
        public string GetComputerAction()
        {
            return ComputerAction.ToString();
        }
        /// <summary>
        /// Gets the player action as a string.
        /// </summary>
        /// <returns></returns>
        public string GetPlayerAction()
        {
            return PlayerAction.ToString();
        }
    }
}