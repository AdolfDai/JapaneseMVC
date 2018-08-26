namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("練習A-Table")]
    public partial class 練習A_Table
    {
        [Key]
        public int 練習AID { get; set; }

        public string 練習A { get; set; }

        public string 練習Answer1 { get; set; }

        public int? 第課ID { get; set; }

        [StringLength(50)]
        public string 練習AImage { get; set; }

        public string 練習AVietnamese { get; set; }

        public string 練習AAnswerVietnamese { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}