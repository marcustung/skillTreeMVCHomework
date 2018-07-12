using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace ASPNETMVCHomeworkDay1.ViewModels
{
	public class MoneyViewModel
	{
		[DisplayName("類別")]
		public string Category { get; set; }
		[DisplayName("金額")]
		public int Money{ get; set; }
		[DisplayName("日期")]
		public DateTime Date{ get; set; }
		[DisplayName("備註")]
		public string Description { get; set; }
	}
}