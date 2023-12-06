using Microsoft.AspNetCore.Mvc;

namespace TicariOtomasyon.ViewComponents
{
	public class _LoginCariKayitComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
