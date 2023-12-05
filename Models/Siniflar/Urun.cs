using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Urun
	{
		[Key]
		public int UrunID { get; set; }
		public string UrunAd { get; set; }
		public string Marka { get; set; }
		public short Stok { get; set; }
		public decimal AlisFiyat { get; set; }
		public decimal SatisFiyat { get; set; }
		public bool Durum { get; set; }
		public string UrunGorsel { get; set; }
	}
}
