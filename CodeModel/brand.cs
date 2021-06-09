namespace CodeModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("production.brands")]
    public partial class brand
    {
        [Key]
        public int brand_id { get; set; }

        [Required]
        [StringLength(255)]
        public string brand_name { get; set; }
    }
}
