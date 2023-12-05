using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class SatisHareket
	{
		[Key]
		public int SatisHareketID { get; set; }
		public DateTime Tarih { get; set; }
		public int Adet { get; set; }
		public decimal Fiyat { get; set; }
		public decimal ToplamTutar { get; set; }
		public Urun Urun { get; set; }
		public Cari Cari { get; set; }
		public Personel Personel { get; set; }
	}
}
