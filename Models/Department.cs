namespace NormDiplom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        public int ID { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        public int? Floor { get; set; }

        public int? Place { get; set; }
    }
}
