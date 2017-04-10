namespace QWSL_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SoftballUser
    {
        [Key]
        [Column(Order = 0)]
        public Guid UserGUID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string FirstName { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string LastName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Phone { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Approved { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime LastUpdated { get; set; }

        public bool? ReceiveTexts { get; set; }

        public Guid? TeamID { get; set; }
    }
}
