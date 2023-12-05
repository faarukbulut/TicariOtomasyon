using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Personel
	{
		[Key]
		public int PersonelID { get; set; }
		public string PersonelAd { get; set; }
		public string PersonelSoyad { get; set; }
		public string PersonelGorsel { get; set; }
	}
}
