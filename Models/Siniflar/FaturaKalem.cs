using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class FaturaKalem
	{
		[Key]
		public int FaturaKalemID { get; set; }
		public string Aciklama { get; set; }
		public int Miktar { get; set; }
		public decimal BirimFiyat { get; set; }
		public decimal Tutar { get; set; }
	}
}
