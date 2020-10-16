using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    public class AlumnoController : Controller
    {
       public ActionResult Index()
        {
            return View();
        }
    }
}
