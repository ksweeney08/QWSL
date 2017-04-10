namespace QWSL_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("League")]
    public partial class League
    {
        public Guid LeagueID { get; set; }

        [Required]
        [StringLength(300)]
        public string LeagueName { get; set; }
    }
}
