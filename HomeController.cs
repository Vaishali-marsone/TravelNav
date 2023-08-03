using Microsoft.AspNetCore.Mvc;

namespace demo1
{
    public class HomeController : Controller
    {
        private SampleDBContext db=new SampleDBContext()
        public IActionResult Index(string searchBy,string search)

        {
            if(searchBy=="Source")
            {
                return View(db.Vehicles1.Where(X => x.Source == search || search == null).ToList());
            }

            if (searchBy == "Destination")

            {
                return View(db.Vehicles1.Where(X => x.Destination == StartWith(search) || search == null).ToList());

            }


            return View();
        }
    }

    internal class SampleDBContext
    {
        public SampleDBContext()
        {
        }
    }
}
