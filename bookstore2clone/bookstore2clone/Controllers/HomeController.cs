using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bookstore2clone.Controllers
{
    public class HomeController : Controller
    {
        public string index()
        {
            return "mvc home controller";
        }
    }
}
