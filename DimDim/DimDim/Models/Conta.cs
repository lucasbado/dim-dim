using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DimDim.Models
{
    [Table("Conta")]
    public class Conta
    {

        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("Agencia")]
        [Display(Name = "Agencia")]
        public string Agencia { get; set; }
        [Column("NumConta")]
        [Display(Name = "Conta")]
        public int NumConta { get; set; }
    
        
    }
}
