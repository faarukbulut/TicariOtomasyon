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
		public ICollection<Urun> Uruns { get; set; }
		public ICollection<Cari> Caris { get; set; }
		public ICollection<Personel> Personels { get; set; }
	}
}
