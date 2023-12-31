﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Siniflar
{
	public class FaturaKalem
	{
		[Key]
		public int FaturaKalemID { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(1000)]
		public string Aciklama { get; set; }

		public int Miktar { get; set; }
		public decimal BirimFiyat { get; set; }
		public decimal Tutar { get; set; }

		public int FaturaID { get; set; }
		public Fatura Fatura { get; set; }
	}
}
