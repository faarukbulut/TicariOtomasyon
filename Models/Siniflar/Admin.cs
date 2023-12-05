using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Admin
	{
		[Key]
		public int AdminID { get; set; }
		public string KullaniciAd { get; set; }
		public string Sifre { get; set; }
		public string Yetki { get; set; }
	}
}
