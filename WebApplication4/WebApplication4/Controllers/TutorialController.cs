using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class TutorialController : Controller
    {
        TutorialDbContext _tutorialDbContext;
        public TutorialController(TutorialDbContext tutorialDbContext)
        {
            _tutorialDbContext = tutorialDbContext;
        }
        public IActionResult Index()
        {
            var tutorialList = _tutorialDbContext.tutorial.ToList();//select *from tutorial
            return View(tutorialList);
        }
        public IActionResult TutorialEntry()
        {
            return View();
        }
        public IActionResult EditTutorial(int TutorialId)
        {
            var tutorialResult = _tutorialDbContext.tutorial.Find(TutorialId);//select * from tutorial where tutorialid=TutorialId
            return View(tutorialResult);
        }
        public IActionResult DeleteTutorial(int TutorialId)
        {
            var tutorialResult = _tutorialDbContext.tutorial.Find(TutorialId);
            return View(tutorialResult);
        }


        [HttpPost]
        public IActionResult TutorialEntry(Tutorial tutorial)
        {
            _tutorialDbContext.tutorial.Add(tutorial);//insert into tutorial values(tutorial.id,tutorial.name,tutorial.desc,tutorial.published,tutorial.fees)
            _tutorialDbContext.SaveChanges();
            //ViewBag,Viewdata,tempdata
            ViewBag.message = "Tutorial details saved successfully";
            return View();
        }
        
        [HttpPost]
        public IActionResult EditTutorial(Tutorial tutorial)
        {
            _tutorialDbContext.Entry(tutorial).State = EntityState.Modified;
            _tutorialDbContext.SaveChanges();
            ViewBag.message = "Tutorial details updated successfully";
            return View();
        }
        
        [HttpPost]
        public IActionResult DeleteTutorial(Tutorial tutorial)
        {
            _tutorialDbContext.Entry(tutorial).State = EntityState.Deleted;
            _tutorialDbContext.SaveChanges();
            ViewBag.message = "Tutorial details deleted successfully";
            return View();

        }



    }
}
