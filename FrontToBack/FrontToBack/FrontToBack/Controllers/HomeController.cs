
using FrontToBack.Models;
using FrontToBack.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.IO;

namespace FrontToBack.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            List<Service> services = GetAllServices();
            List<Feature> features = GetAllFeatures();
            List<Project> projects = GetAllProjects();
            List<Team> team = GetAllTeam();
            List<Testimonial> testimonials = GetAllTestimonials();

            HomeVM model = new()
            {
                Id = 1,
                Services = services,
                Features = features,
                Projects = projects,
                Team = team,
                Testimonials = testimonials
            };
            return View(model);
        }

        private List<Service> GetAllServices()
        {
            Service s1 = new()
            {
                Id = 1,
                Title = "Anar",
                Description = "Anar Description",
                Icon = "icon-1.png"
            };
            Service s2 = new()
            {
                Id = 2,
                Title = "Tunar",
                Description = "Tunar Description",
                Icon = "icon-2.png"
            };
            Service s3 = new()
            {
                Id = 3,
                Title = "Elnar",
                Description = "Elnar Description",
                Icon = "icon-3.png"
            };
            Service s4 = new()
            {
                Id = 4,
                Title = "Atilla",
                Description = "Atilla Description",
                Icon = "icon-4.png"
            };
            Service s5 = new()
            {
                Id = 5,
                Title = "Nihat",
                Description = "Nihat Description",
                Icon = "icon-5.png"
            };
            Service s6 = new()
            {
                Id = 6,
                Title = "Tuncay",
                Description = "Tuncay Description",
                Icon = "icon-6.png"
            };

            List<Service> services = new List<Service>() { s1, s2, s3, s4,s5,s6};
            return services;
        }

        private List<Feature> GetAllFeatures()
        {
            Feature f1 = new()
            {
                Id = 1,
                Icon = "icon-1.png",
                Title = "Database Management",
                Description = "This card includes features related to managing database operations."
            };
            Feature f2 = new()
            {
                Id = 2,
                Icon = "icon-2.png",
                Title = "Server Management Card",
                Description = "This card includes features related to server database operations."
            };
            Feature f3 = new()
            {
                Id = 3,
                Icon = "icon-3.png",
                Title = "Security Management",
                Description = "This card includes features related to managing security."
            };
            Feature f4 = new()
            {
                Id = 4,
                Icon = "icon-4.png",
                Title = "API Management",
                Description = "This card includes features related to managing application programming interface (API) operations. "
            };

            List<Feature> features = new() { f1, f2, f3, f4 };
            return features;
           
        }
        
        private List<Project> GetAllProjects()
        {

            Project p1 = new()
            {
                Id = 1,
                Title = "Real-time Chat Application",
                Description = "This card is for building a real-time chat application.",
                Image = "project-1.jpg"
            };
            Project p2 = new()
            {
                Id = 2,
                Title = " E-commerce Website",
                Description = "This card is for building an e-commerce website.",
                Image = "project-2.jpg"
            };
            Project p3 = new()
            {
                Id = 3,
                Title = "Social Network Platform",
                Description = "This card is for building a social network platform.",
                Image = "project-3.jpg"
            };
            Project p4 = new()
            {
                Id = 4,
                Title = "Task Management System",
                Description = "This card is for building a task management system. ",
                Image = "project-4.jpg"
            };

            List<Project> projects = new() { p1, p2, p3, p4 };
            return projects;
        }

        private List<Team> GetAllTeam()
        {
            Team t1 = new()
            {
                Id = 1,
                FullName = "Huseynov Anar",
                Position = "Full Stack Developer",
                Image = "team-1.jpg"
            };
            Team t2 = new()
            {
                Id = 2,
                FullName = "Huseynli Elnar",
                Position = "Front End Developer",
                Image = "team-2.jpg"
            };
            Team t3 = new()
            {
                Id = 3,
                FullName = "Huseynli Tunar",
                Position = "Back End Developer",
                Image = "team-3.jpg"
            };
            Team t4 = new()
            {
                Id = 4,
                FullName = "Rehimli Tuncay",
                Position = "UX/UI Designer",
                Image = "team-4.jpg"
            };

            List<Team> team = new() { t1, t2, t3, t4 };
            return team;
        }

        private List<Testimonial> GetAllTestimonials()
        {
            Testimonial testimonial1 = new()
            {
                id = 1,
                FullName = "John Smith",
                Description = "John has been instrumental in the development of our back-end infrastructure.",
                Position = "Senior Developer",
                Image = "testimonial-3.jpg"
            };
            Testimonial testimonial2 = new()
            {
                id = 2,
                FullName = "Maria Rodriguez",
                Description = "Maria is a talented back-end engineer who has been a key contributor to our project's success.",
                Position = "Back-end Engineer",
                Image = "testimonial-1.jpg"
            };
            Testimonial testimonial3 = new()
            {
                id = 3,
                FullName = "Michael Thompson",
                Description = "Michael is a highly skilled back-end architect who has designed and implemented. ",
                Position = "Back-end Architect",
                Image = "testimonial-2.jpg"
            };
            Testimonial testimonial4 = new()
            {
                id = 4,
                FullName = "Sarah Lee",
                Description = "Sarah is an outstanding back-end developer who has been a great asset to our team. ",
                Position = "Back-end Developer",
                Image = "testimonial-4.jpg"
            };

            List<Testimonial> testimonials = new() { testimonial1, testimonial2, testimonial3, testimonial4 };
            return testimonials;

        }
    }
}