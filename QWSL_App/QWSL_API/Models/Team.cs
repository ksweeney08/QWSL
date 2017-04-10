namespace QWSL_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Team
    {
        [Key]
        public Guid TeamGUID { get; set; }

        public int TeamID { get; set; }

        public Guid LeagueID { get; set; }

        public int DivisionID { get; set; }

        [Required]
        [StringLength(300)]
        public string TeamName { get; set; }

        public bool? ScoresMissing { get; set; }
    }
}
