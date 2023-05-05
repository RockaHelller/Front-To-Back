using Front_To_Back.Models;
using Front_To_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace Front_To_Back.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            Feature f1 = new()
            {
                Id = 1,
                Title = "Murad",
                Description = "Murad description",
                Icon = "icon-1.png"
            };

            Feature f2 = new()
            {
                Id = 2,
                Title = "Musa",
                Description = "Musa description",
                Icon = "icon-2.png"
            };

            Feature f3 = new()
            {
                Id = 3,
                Title = "Resul",
                Description = "Resul description",
                Icon = "icon-3.png"
            };

            Feature f4 = new()
            {
                Id = 4,
                Title = "Nicat",
                Description = "Nicat description",
                Icon = "icon-4.png"
            };






            Service s1 = new()
            {
                Id = 1,
                Title = "Murad",
                Description = "Murad description",
                Icon = "icon-1.png"
            };

            Service s2 = new()
            {
                Id = 2,
                Title = "Musa",
                Description = "Musa description",
                Icon = "icon-2.png"
            };

            Service s3 = new()
            {
                Id = 3,
                Title = "Resul",
                Description = "Resul description",
                Icon = "icon-3.png"
            };

            Service s4 = new()
            {
                Id = 4,
                Title = "Nicat",
                Description = "Nicat description",
                Icon = "icon-4.png"
            };

            Service s5 = new()
            {
                Id = 5,
                Title = "Mahir",
                Description = "Mahir description",
                Icon = "icon-5.png"
            };

            Service s6 = new()
            {
                Id = 6,
                Title = "Ramil",
                Description = "Ramil description",
                Icon = "icon-6.png"
            };

            HomeVM model = new()
            {
                Features = new List<Feature>() { f1, f2, f3, f4 },
                Service = new List<Service>() { s1, s2, s3, s4, s5, s6 }
            };


            return View(model);

        }

    }
}