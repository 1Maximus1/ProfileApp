using Microsoft.AspNetCore.Mvc;
using UserProfileApp.Models;
using UserProfileApp.Services;

namespace UserProfileApp.Controllers
{
    public class PersonController:Controller
    {
        UserService userService = new UserService();

        [HttpGet]
        public IActionResult Index()
        {
            Person person = userService.getUserDataFromJSON("Oleg_Tarasenko");

            person.Img = userService.getUserPhoto("Oleg_Tarasenko.jpg");

            string base64Image = Convert.ToBase64String(person.Img);
            ViewBag.ImageData = base64Image;

            return View(person);
        }


        [HttpGet]
        public IActionResult Hobby()
        {
            Person person = userService.getUserDataFromJSON("Oleg_Tarasenko");

            person.Img = userService.getUserPhoto("Oleg_Tarasenko.jpg");

            return View(person);
        }


    }
}
