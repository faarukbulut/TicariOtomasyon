using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Cari
	{
		[Key]
		public int CariID { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string CariAd { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(30)]
		public string CariSoyad { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(13)]
		public string CariSehir { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(50)]
		public string CariMail { get; set; }

		public bool Durum { get; set; }

		public ICollection<SatisHareket> SatisHarekets { get; set; }
	}
}
