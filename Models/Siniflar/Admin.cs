﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Siniflar
{
	public class Admin
	{
		[Key]
		public int AdminID { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(10)]
		public string KullaniciAd { get; set; }

		[Column(TypeName = "Varchar")]
		[StringLength(10)]
		public string Sifre { get; set; }

		[Column(TypeName = "Char")]
		[StringLength(1)]
		public string Yetki { get; set; }
	}
}
