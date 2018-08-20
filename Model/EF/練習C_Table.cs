namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("練習C-Table")]
    public partial class 練習C_Table
    {
        [Key]
        public int 練習CID { get; set; }

        [StringLength(50)]
        public string 練習CAudio { get; set; }

        [StringLength(50)]
        public string 練習CImg { get; set; }

        public string 練習C例 { get; set; }

        public string 練習C例VNI { get; set; }

        public string 練習C1Ans { get; set; }

        public string 練習C1AnsVNI { get; set; }

        public string 練習C2Ans { get; set; }

        public string 練習C2AnsVNI { get; set; }

        public string 練習C3Ans { get; set; }

        public string 練習C3AnsVNI { get; set; }

        public int? 第課ID { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}