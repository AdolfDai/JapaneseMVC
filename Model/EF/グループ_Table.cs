namespace Model.EF
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("グループ-Table")]
    public partial class グループ_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public グループ_Table()
        {
            N5動詞_Table = new HashSet<N5動詞_Table>();
        }

        [Key]
        public int グループID { get; set; }

        [StringLength(50)]
        public string グループ { get; set; }

        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<N5動詞_Table> N5動詞_Table { get; set; }
    }
}