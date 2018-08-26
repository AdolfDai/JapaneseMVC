namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("問題-Table")]
    public partial class 問題_Table
    {
        [Key]
        public int 問題ID { get; set; }

        [StringLength(50)]
        public string 問題Img { get; set; }

        [StringLength(50)]
        public string 問題Audio { get; set; }

        public string 問題 { get; set; }

        public string 問題Text { get; set; }

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

        public virtual 第課_Table 第課_Table { get; set; }
    }
}