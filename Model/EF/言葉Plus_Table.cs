namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("言葉Plus-Table")]
    public partial class 言葉Plus_Table
    {
        [Key]
        public int 言葉PlusID { get; set; }

        [StringLength(50)]
        public string ひらがな { get; set; }

        [StringLength(50)]
        public string 漢字 { get; set; }

        [StringLength(50)]
        public string 音漢字 { get; set; }

        public string ベトナム語 { get; set; }

        public int? 第課ID { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}