namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("例文-Table")]
    public partial class 例文_Table
    {
        [Key]
        public int 例文ID { get; set; }

        public string 例文 { get; set; }

        public int? 第課ID { get; set; }

        public string 例文Vietnamese { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}