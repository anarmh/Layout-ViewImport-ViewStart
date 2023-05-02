using Layout_ViewModel.Models;
using Layout_ViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Layout_ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //ViewData["name"] = "Anar";
            //ViewData["nums"]=new int[] {1,2,3,4};
            //ViewBag.surname = "Huseynov";
            //TempData["address"] = "Sumqayit";
            //Student stu1 = new Student()
            //{
            //    Id = 1,
            //    FullName = "Huseynov Anar",
            //    Address = "Sumqayit",
            //    Age = 36
            //};
            //Student stu2 = new Student()
            //{
            //    Id = 2,
            //    FullName = "Huseynli Tunar",
            //    Address = "5mkr",
            //    Age = 26
            //};
            //Student stu3 = new()
            //{
            //    Id = 3,
            //    FullName = "Huseynli Elnar",
            //    Address = "6mkr",
            //    Age = 19
            //};

            //List<Student> students = new List<Student>() { stu1,stu2, stu3 };

            //string logo = "Site logo";

            //Slider slider = new()
            //{
            //    Id = 1,
            //    Image = "https://www.simplilearn.com/ice9/free_resources_article_thumb/what_is_image_Processing.jpg"
            //};

            //HomeVM model = new()
            //{
            //    Logo = logo,
            //    Student = students,
            //    Slider= slider
            //};
            return View(/*model*/);
        }

        //public IActionResult Details()
        //{
        //    return  View();
        //}
    }
}
