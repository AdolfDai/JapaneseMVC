namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Administrator")]
    public partial class Administrator
    {
        [StringLength(20)]
        public string Id { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(255)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string CreadtedBy { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(50)]
        public string RoleName { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public bool Status { get; set; }
    }
}
