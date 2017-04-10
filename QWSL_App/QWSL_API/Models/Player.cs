namespace QWSL_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        public Guid PlayerID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(300)]
        public string Email { get; set; }

        [StringLength(50)]
        public string CellPhone { get; set; }

        public Guid? LeagueID { get; set; }

        public int? TeamID { get; set; }
    }
}
