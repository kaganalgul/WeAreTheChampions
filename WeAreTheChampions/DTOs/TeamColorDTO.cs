using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.DTOs
{
    public class TeamColorDTO
    {
        public int Id { get; set; }

        public string ColorName { get; set; }

        public int TeamId { get; set; }

        public int ColorId { get; set; }
    }
}
