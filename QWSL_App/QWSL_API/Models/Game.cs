using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace QWSL_API.Models

{
    [Table("Schedule")]
    public partial class Game
    {
        [Key]
        public Guid GameID { get; set; }
        public DateTime GameDate { get; set; }
        public Guid HomeTeam { get; set; }
        public Guid AwayTeam { get; set; }
        [StringLength(200)]
        public string Field { get; set; }
        public int? ScoreHome { get; set; }
        public int? ScoreAway { get; set; }
        public Guid? LeagueID { get; set; }
        [StringLength(4)]
        public string Season { get; set; }
        public bool Playoff { get; set; }
        public bool Postponed { get; set; }


    }
}