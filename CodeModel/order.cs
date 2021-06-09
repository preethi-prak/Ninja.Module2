namespace CodeModel
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sales.orders")]
    public partial class order
    {
        [Key]
        public int order_id { get; set; }

        public int? customer_id { get; set; }

        public byte order_status { get; set; }

        [Column(TypeName = "date")]
        public DateTime order_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime required_date { get; set; }

        [Column(TypeName = "date")]
        public DateTime? shipped_date { get; set; }

        public int store_id { get; set; }

        public int staff_id { get; set; }

        public virtual customer customer { get; set; }

        public virtual staff staff { get; set; }

        public virtual store store { get; set; }
    }
}
