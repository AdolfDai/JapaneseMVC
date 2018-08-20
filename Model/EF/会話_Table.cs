namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("会話-Table")]
    public partial class 会話_Table
    {
        [Key]
        public int 会話ID { get; set; }

        public string 会話 { get; set; }

        public int? 第課ID { get; set; }

        [StringLength(50)]
        public string 会話Image { get; set; }

        [StringLength(100)]
        public string 会話Audio { get; set; }

        [StringLength(50)]
        public string 会話Video { get; set; }

        public string 会話Vietnamese { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}