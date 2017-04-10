namespace QWSL_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Division
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DivisionID { get; set; }

        public Guid LeagueID { get; set; }

        [Required]
        [StringLength(300)]
        public string DivisionName { get; set; }
    }
}
