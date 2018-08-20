namespace Model.EF
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("第課-Table")]
    public partial class 第課_Table
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 第課_Table()
        {
            GrammarNihongoes = new HashSet<GrammarNihongo>();
            会話_Table = new HashSet<会話_Table>();
            例文_Table = new HashSet<例文_Table>();
            問題_Table = new HashSet<問題_Table>();
            形容詞 = new HashSet<形容詞>();
            文型_Table = new HashSet<文型_Table>();
            漢字___Table = new HashSet<漢字___Table>();
            練習A_Table = new HashSet<練習A_Table>();
            練習Ｂ_Table = new HashSet<練習Ｂ_Table>();
            練習C_Table = new HashSet<練習C_Table>();
            言葉Plus_Table = new HashSet<言葉Plus_Table>();
            言葉_Table = new HashSet<言葉_Table>();
        }

        [Key]
        public int 第課ID { get; set; }

        public string 第課Name { get; set; }

        public string 第課Subject { get; set; }

        [StringLength(100)]
        public string 言葉audio { get; set; }

        [StringLength(100)]
        public string 例文audio { get; set; }

        [StringLength(100)]
        public string 文型audio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GrammarNihongo> GrammarNihongoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<会話_Table> 会話_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<例文_Table> 例文_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<問題_Table> 問題_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<形容詞> 形容詞 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<文型_Table> 文型_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<漢字___Table> 漢字___Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<練習A_Table> 練習A_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<練習Ｂ_Table> 練習Ｂ_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<練習C_Table> 練習C_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<言葉Plus_Table> 言葉Plus_Table { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<言葉_Table> 言葉_Table { get; set; }
    }
}