using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("TeamColors")]
    public class TeamColor
    {
        public int Id { get; set; }

        public int TeamId { get; set; }
        public Team Team { get; set; }

        public int ColorId { get; set; }
        public Color Color { get; set; }

    }
}
