using System.ComponentModel.DataAnnotations;

namespace _5º_Av_part01.Models
{
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
