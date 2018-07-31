using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsApp.Controllers;

namespace RockPaperScissorsApp.Tests
{
    [TestClass]
    public class PlayerControllerTests
    {
        /// <summary>
        /// Checks that with invalid input form, validation fails.
        /// </summary>
        [TestMethod]
        public void Index_CheckValidation_Fails()
        {
            PlayerController controller = new PlayerController();
            controller.ViewData.ModelState.Clear();

            Models.PlayerModel player = new Models.PlayerModel
            {
                Name = "asd",
                EMail = "testemail.com",
                Mobile = "07777777777asd"
            };

            var result = controller.Index(player) as ViewResult;

            Assert.IsTrue(!controller.ViewData.ModelState.IsValid);
        }

        /// <summary>
        /// Checks that with valid input form, validation succeeds.
        /// </summary>
        [TestMethod]
        public void Index_CheckValidation_Succeeds()
        {
            PlayerController controller = new PlayerController();
            controller.ViewData.ModelState.Clear();

            Models.PlayerModel player = new Models.PlayerModel
            {
                Name = "name",
                EMail = "test@email.com",
                Mobile = "07777777777"
            };

            var result = controller.Index(player) as ViewResult;

            Assert.IsTrue(controller.ViewData.ModelState.IsValid);
        }
    }
}
