namespace CodeModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vw_CustomerData
    {
        [Key]
        [Column(Order = 0)]
        public int customer_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string first_name { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string email { get; set; }
    }
}
