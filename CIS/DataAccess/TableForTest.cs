namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TableForTest")]
    public partial class TableForTest
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string FieldOne { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string FieldTwo { get; set; }
    }
}
