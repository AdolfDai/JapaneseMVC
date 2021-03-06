namespace Model.EF
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Group動詞
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Group動詞()
        {
            N5動詞_Table = new HashSet<N5動詞_Table>();
        }

        [Key]
        public int GroupNameID { get; set; }

        [StringLength(10)]
        public string GroupName { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<N5動詞_Table> N5動詞_Table { get; set; }
    }
}