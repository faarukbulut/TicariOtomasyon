using Microsoft.AspNetCore.Mvc;

namespace TicariOtomasyon.ViewComponents
{
	public class _LoginCariGirisComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
