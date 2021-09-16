using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AWP_project_transactions.Models;
using Microsoft.AspNetCore.Mvc;

namespace AWP_project_transactions.Controllers
{
    [Route("account")]
    public class AccountController : Controller
    {
        
        public IActionResult register()
        {
            return View("register", new Account());
        }

        [Route("save")]
        [HttpPost]
        public IActionResult Save(Account account)
        {
            if (ModelState.IsValid)
            {
                ViewBag.account = account;
                return View("Success");
            }
            else
            {
                return View("register");
            }
        }
    }
}
