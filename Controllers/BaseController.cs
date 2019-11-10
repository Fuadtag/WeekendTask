using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _08_11_2019WeekendTask.DAL;

namespace _08_11_2019WeekendTask.Controllers
{
    public class BaseController : Controller
    {
        protected readonly _Context context;

        public BaseController()
        {
            context = new _Context();
            
        }
        
       
    }
}