using System.Web.Mvc;
using RockPaperScissorsApp.Core;
using RockPaperScissorsApp.Models;

namespace RockPaperScissorsApp.Controllers
{
    public class GameController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        // GET: Game Start
        public ActionResult Start()
        {
            return View();
        }

        // GET: Game End
        /// <summary>
        /// Determines the outcome of the game, returns end view.
        /// </summary>
        /// <param name="playerAction">The player action.</param>
        /// <returns></returns>
        public ActionResult End(GameAction playerAction)
        {
            GameAction computerAction = GameLogic.GetComputerAction();
            GameResult result = GameLogic.DetermineOutcome(computerAction, playerAction);

            VMGameState model = new VMGameState(playerAction, computerAction, result);
            if(model.GetOutcome() == GameResult.Win)
            {
                //This changes a session attribute that later allows writing the form to text file.
                System.Web.HttpContext.Current.Session["hasUserWon"] = true;
            }
            
            return View(model);
        }
    }
}