using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsApp.Core;
using RockPaperScissorsApp.Models;

namespace RockPaperScissorsApp.Tests
{
    [TestClass]
    public class GameLogicTests
    {
        /** Player chooses paper section **/
        /// <summary>
        /// Determines that paper vs rock returns win.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithPaperVsRock_Win()
        {
            GameAction playerAction = GameAction.Paper;
            GameAction computerAction = GameAction.Rock;
            GameResult expected = GameResult.Win;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Determines that paper vs paper returns draw.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithPaperVsPaper_Draw()
        {
            GameAction playerAction = GameAction.Paper;
            GameAction computerAction = GameAction.Paper;
            GameResult expected = GameResult.Draw;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Determines that paper vs scissors returns lose.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithPaperVsScissors_Lose()
        {
            GameAction playerAction = GameAction.Paper;
            GameAction computerAction = GameAction.Scissors;
            GameResult expected = GameResult.Lose;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }

        /** Player chooses rock section **/
        /// <summary>
        /// Determines that rock vs rock returns draw.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithRockVsRock_Draw()
        {
            GameAction playerAction = GameAction.Rock;
            GameAction computerAction = GameAction.Rock;
            GameResult expected = GameResult.Draw;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Determines that rock vs paper returns lose.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithRockVsPaper_Lose()
        {
            GameAction playerAction = GameAction.Rock;
            GameAction computerAction = GameAction.Paper;
            GameResult expected = GameResult.Lose;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Determines that rock vs scissors returns win.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithRockVsScissors_Win()
        {
            GameAction playerAction = GameAction.Rock;
            GameAction computerAction = GameAction.Scissors;
            GameResult expected = GameResult.Win;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }

        /** Player chooses scissors section **/
        /// <summary>
        /// Determines that scissors vs rock returns lose.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithScissorsVsRock_Lose()
        {
            GameAction playerAction = GameAction.Scissors;
            GameAction computerAction = GameAction.Rock;
            GameResult expected = GameResult.Lose;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Determines that scissors vs paper returns win.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithScissorsVsPaper_Win()
        {
            GameAction playerAction = GameAction.Scissors;
            GameAction computerAction = GameAction.Paper;
            GameResult expected = GameResult.Win;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Determines that scissors vs scissors returns draw.
        /// </summary>
        [TestMethod]
        public void DetermineWin_WithScissorsVsScissors_Draw()
        {
            GameAction playerAction = GameAction.Scissors;
            GameAction computerAction = GameAction.Scissors;
            GameResult expected = GameResult.Draw;

            GameResult actual = GameLogic.DetermineOutcome(computerAction, playerAction);

            Assert.AreEqual(expected, actual);
        }
    }
}
