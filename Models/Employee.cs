namespace NormDiplom.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(30)]
        public string Surname { get; set; }

        [StringLength(30)]
        public string SecondName { get; set; }

        public int? Phone { get; set; }

        [StringLength(40)]
        public string Department { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        public int? ReservedBookID { get; set; }

        public virtual Book Book { get; set; }
    }
}
