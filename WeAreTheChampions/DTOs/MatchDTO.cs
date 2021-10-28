using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreTheChampions.Models;
using static WeAreTheChampions.Enums.EnumClass;

namespace WeAreTheChampions.DTOs
{
    public class MatchDTO
    {
        public int Id { get; set; }

        public DateTime MatchTime { get; set; }

        public string Team1Isim { get; set; }

        public string Team2Isim { get; set; }

        public int? Score1 { get; set; }

        public int? Score2 { get; set; }

        public Result? Result { get; set; }

    }
}
