using System.Web;
using System.Web.Mvc;

namespace ASPNETMVCHomeworkDay1
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
