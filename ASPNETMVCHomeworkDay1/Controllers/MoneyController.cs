using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPNETMVCHomeworkDay1.ViewModels;

namespace ASPNETMVCHomeworkDay1.Controllers
{
    public class MoneyController : Controller
    {
        // GET: Money
		
        public ActionResult Index()
        {
			return View();
        }

		[ChildActionOnly]
	    public ActionResult List()
	    {
		    ViewData.Model = GetMoneyList();
		    return View();
	    }

	    private List<MoneyViewModel> GetMoneyList()
	    {
			List<MoneyViewModel> data = new List<MoneyViewModel>();

		    for (int i = 0; i < 50; i++)
		    {
			    data.Add(
					new MoneyViewModel()
					{
						Category = (i % 3 == 0)? "支出":"收入",
						Date = new DateTime(2018,6,1).AddDays(i),
						Money = i * 100,
						Description = ""
					}
				);
		    }
		    return data;
	    }
    }
}
