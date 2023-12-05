using System.ComponentModel.DataAnnotations;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Fatura
	{
		[Key]
		public int FaturaID { get; set; }
		public string FaturaSeriNo { get; set; }
		public string FaturaSiraNo { get; set; }
		public DateTime Tarih { get; set; }
		public string VergiDairesi { get; set; }
		public DateTime Saat { get; set; }
		public string TeslimEden { get; set; }
		public string TeslimAlan { get; set; }
	}
}
