namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("練習Ｂ-Table")]
    public partial class 練習Ｂ_Table
    {
        [Key]
        public int 練習ＢID { get; set; }

        public string 練習Ｂ { get; set; }

        public string 練習ＢAnswer { get; set; }

        [StringLength(50)]
        public string 練習ＢImg { get; set; }

        public string 練習BVietnamese { get; set; }

        public int 第課ID { get; set; }
        public virtual 第課_Table 第課_Table { get; set; }
    }
}