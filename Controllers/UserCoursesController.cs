using CourseApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CourseApp.Controllers
{
    public class UserCoursesController : Controller
    {
        public UserCoursesController()
        {
        }

        // GET: UserCourses
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserCourses/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserCourses/Create
        public ActionResult Create(UserCourseDto course)
        {
            return View();
        }

        // POST: UserCourses/Create
        

        // GET: UserCourses/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        

        // GET: UserCourses/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        
    }
}
