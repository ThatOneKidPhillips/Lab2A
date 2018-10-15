using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Attacks1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab1b.Controllers
{
    public class AttacksController : Controller
    {
        public IActionResult XSSHello(string name)
        {
            string greeting = $"Welcome {name} to our application";
            // string safeGreeting = System.Net.WebUtility.HtmlEncode(greeting);
            ContentResult result = new ContentResult();
            result.ContentType = "text/html";
            result.Content = greeting;
            return result;
        }

        public IActionResult SafeHello(string name)
        {
            string greeting = $"Welcome {name} to our application";
            string safeGreeting = System.Net.WebUtility.HtmlEncode(greeting);
            ContentResult result = new ContentResult();
            result.ContentType = "text/html";
            result.Content = safeGreeting;
            return result;
        }

        public IActionResult FormHello(Greeting greeting)
        {
            ViewBag.Message = $"Welcome {greeting.Login} to our application";
            return View(greeting);
        }

        public IActionResult UnsafeFormHello(Greeting greeting)
        {
            ViewBag.Message = $"Welcome {greeting.Login} to our application";
            return View(greeting);
        }
    }
}