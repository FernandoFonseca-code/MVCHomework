using Microsoft.AspNetCore.Mvc;
using MVCHomework.Models;

namespace MVCHomework.Controllers
{
    public class PCController : Controller
    {
        [HttpGet] // GET: /PC/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost] // This Create action is hit after the user submits the form
        public IActionResult Create(IFormCollection BuildFormData)
        {
            // validate all data

            BuiltPC newBuild = new()
            {
                Title = BuildFormData["BuildTitle"],
                Type = BuildFormData["BuildType"],
                CPU = BuildFormData["CPU"],
                GPU = BuildFormData["GPU"],
                Budget = Convert.ToDouble(BuildFormData["Budget"])
            };


            // Add to database
            // BuiltPCDb.Add(newBuild);

            // Add modal dialog box confirming information
            // Message.Show("Build Created", "Your build has been created successfully", "success");

            // Return a view
            return RedirectToAction("Index", "Home");
        }

        [HttpGet] // 
        public IActionResult CreateLaptop()

        {
            return View();
        }
    }
}
