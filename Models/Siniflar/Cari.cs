using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Cari
	{
		[Key]
		public int CariID { get; set; }
		public string CariAd { get; set; }
		public string CariSoyad { get; set; }
		public string CariSehir { get; set; }
		public string CariMail { get; set; }
	}
}
