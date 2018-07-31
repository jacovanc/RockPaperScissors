using RockPaperScissorsApp.Core;
using RockPaperScissorsApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace RockPaperScissorsApp.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Post player object form and validates
        /// </summary>
        /// <param name="player">The player.</param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Index(PlayerModel player) 
        {
            if (string.IsNullOrEmpty(player.Name))
            {
                ModelState.AddModelError("Name", "Name is required");
            }
            if (string.IsNullOrEmpty(player.EMail))
            {
                ModelState.AddModelError("EMail", "EMail is required");
            }
            else
            {
                string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                           @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
                Regex emailReg = new Regex(emailRegex);
                if (!emailReg.IsMatch(player.EMail))
                {
                    ModelState.AddModelError("EMail", "EMail is not valid");
                }
            }
            if (!string.IsNullOrEmpty(player.Mobile))
            {
                string mobileRegex = @"^[0-9]*$";
                Regex mobileReg = new Regex(mobileRegex);
                if (!mobileReg.IsMatch(player.Mobile))
                {
                    ModelState.AddModelError("Mobile", "Mobile is not valid");
                }
            }

            bool hasWon = false;
            try
            {
                hasWon = (bool)System.Web.HttpContext.Current.Session["hasUserWon"];
            }
            catch (Exception e) { }

            //Although this form page can be loaded without winning first, the inputs will not be written to file.
            if (ModelState.IsValid && hasWon) 
            {
                try
                {
                    FileWriter.WritePlayerToFile(player);
                } catch (Exception e)
                {
                    Debug.Write(e);
                }
                return View("Finish");
            }

            return View();
        }
    }
}