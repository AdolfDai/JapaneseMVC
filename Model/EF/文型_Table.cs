namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("文型-Table")]
    public partial class 文型_Table
    {
        [Key]
        public int 文型ID { get; set; }

        public string 文型 { get; set; }

        public int 第課ID { get; set; }

        public string 文型Vietnamese { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}