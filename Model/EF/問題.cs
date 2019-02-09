namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 問題
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 問題()
        {
            問題の答えTable = new HashSet<問題の答えTable>();
        }

        public int 問題ID { get; set; }

        [StringLength(50)]
        public string 問題の写真 { get; set; }

        [StringLength(50)]
        public string 問題Audio { get; set; }

        public string 問題の本 { get; set; }

        public string ベトナム語 { get; set; }

        public string 問題Rei { get; set; }

        public string 問題VNIRei { get; set; }

        public string 問題1 { get; set; }

        public string 問題VNI1 { get; set; }

        public string 問題2 { get; set; }

        public string 問題VNI2 { get; set; }

        public string 問題3 { get; set; }

        public string 問題VNI3 { get; set; }

        public string 問題4 { get; set; }

        public string 問題VNI4 { get; set; }

        public string 問題5 { get; set; }

        public string 問題VNI5 { get; set; }

        public int? 第課ID { get; set; }

        public virtual 第課 第課 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<問題の答えTable> 問題の答えTable { get; set; }
    }
}
