namespace QWSL_API
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Content")]
    public partial class Content
    {
        public int ContentID { get; set; }

        [Required]
        [StringLength(120)]
        public string PageName { get; set; }

        [Column("Content", TypeName = "text")]
        public string Content1 { get; set; }

        public DateTime? DateStamp { get; set; }
    }
}
