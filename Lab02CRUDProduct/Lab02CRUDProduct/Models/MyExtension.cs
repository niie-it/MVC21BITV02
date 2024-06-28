using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab02CRUDProduct.Models
{
	public static class MyExtension
	{
		public static IHtmlContent SayHello(this IHtmlHelper helper, string name = "Tòe")
		{
			return new HtmlString($"<h1> Hello {name}</h1>");

		}

		public static int NgayConLai(this int year)
		{
			return (new DateTime(year, 1, 1, 0, 0, 0) - DateTime.Now).Days;
		}
	}
}
