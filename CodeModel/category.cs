namespace CodeModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("production.categories")]
    public partial class category
    {
        [Key]
        public int category_id { get; set; }

        [Required]
        [StringLength(255)]
        public string category_name { get; set; }
    }
}
