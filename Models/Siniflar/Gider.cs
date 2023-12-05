using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Gider
	{
		[Key]
		public int GiderID { get; set; }
		public string Aciklama { get; set; }
		public DateTime Tarih { get; set; }
		public decimal Tutar { get; set; }
	}
}
