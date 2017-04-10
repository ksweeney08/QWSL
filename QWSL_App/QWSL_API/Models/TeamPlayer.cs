namespace QWSL_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TeamPlayer
    {
        [Key]
        [Column(Order = 0)]
        public Guid PlayerID { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid TeamID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string Season { get; set; }
    }
}
