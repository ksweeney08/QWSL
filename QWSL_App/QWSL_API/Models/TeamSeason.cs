namespace QWSL_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeamSeason
    {
        [Key]
        [Column(Order = 0)]
        public Guid TeamID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string Season { get; set; }
    }
}
