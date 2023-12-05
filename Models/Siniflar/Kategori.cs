using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Kategori
	{
		[Key]
		public int KategoriID { get; set; }
		public string KategoriAd { get; set; }
	}
}
