using Microsoft.AspNetCore.Mvc;
using a.Models;
namespace a.Controllers
{

    public class ulohyController : Controller
    {
        public IActionResult uloha1()
        {
            return View();
        }
        public IActionResult uloha2()
        {
            return View();
        }
        public IActionResult uloha3()
        {
            return View();
        }

        public IActionResult uloha4()
        {
            var userinfolist = new List<UserInfo>()
            {
                new UserInfo {
                    Tel = 123456789,
                    Name = "Jakub Virlic",
                    Email = "asdas@gmail.com",
                    UserName = "virlicjakub"
                },
                new UserInfo {
                    Tel = 123456789,
                    Name = "Jakub Virlic",
                    Email = "asdas@gmail.com",
                    UserName = "virlicjakub"
                },
                new UserInfo {
                    Tel = 123456789,
                    Name = "Jakub Virlic",
                    Email = "asdas@gmail.com",
                    UserName = "virlicjakub"
                }
            };
            return View(userinfolist);
        }
        public IActionResult uloha5()
        {
            var userinfolist = new List<UserInfo>()
            {
                new UserInfo {
                    Tel = 123456789,
                    Name = "Jakub Virlic",
                    Email = "asdas@gmail.com",
                    UserName = "virlicjakub"
                },
                new UserInfo {
                    Tel = 123456789,
                    Name = "Jakub Virlic",
                    Email = "asdas@gmail.com",
                    UserName = "virlicjakub"
                },
                new UserInfo {
                    Tel = 123456789,
                    Name = "Jakub Virlic",
                    Email = "asdas@gmail.com",
                    UserName = "virlicjakub"
                }
            };
            return View(userinfolist);
        }

    }
}
