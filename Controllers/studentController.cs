using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication2.Models; 

namespace WebApplication2.Controllers
{
    public class studentController : Controller
    {   
        public IActionResult Index()
        {
           StudentInfo studentInfo = new StudentInfo();
            List<Student> students = new List<Student>();
            students=studentInfo.getall();
            return View("all",students);
        }
        public IActionResult detail(int id )
        {
            StudentInfo studentInfo = new StudentInfo();
            List<Student> students = new List<Student>();
            Student a = studentInfo.getid(id);
            return View("detail", a);
        }
    }
}
