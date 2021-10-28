using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Colors")]
    public class Color
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string ColorName { get; set; }

        [Range(0, 255, ErrorMessage ="Gireceğiniz veri 0 ile 255 dahil aralığında olmalıdır.")]
        public int Red {get; set;}

        [Range(0, 255, ErrorMessage = "Gireceğiniz veri 0 ile 255 dahil aralığında olmalıdır.")]
        public int Green { get; set; }

        [Range(0, 255, ErrorMessage = "Gireceğiniz veri 0 ile 255 dahil aralığında olmalıdır.")]
        public int Blue { get; set; }

        public ICollection<TeamColor> TeamColors { get; set; } = new HashSet<TeamColor>();
    }
}
