using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicariOtomasyon.Models.Siniflar
{
    public class ToDo
    {
        [Key]
        public int ToDoID { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(100)]
        public string Baslik { get; set; }

        [Column(TypeName = "bit")]
        public bool Durum { get; set; }
    }
}
