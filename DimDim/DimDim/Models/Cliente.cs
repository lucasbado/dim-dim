using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimDim.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Usuario")]
        public string Usuario { get; set; }
       
        [Column("Senha")]
        [Display(Name = "Senha")]
        public string Senha { get; set; }

        [Column("Email")]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}

