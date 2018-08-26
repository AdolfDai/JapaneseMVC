namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("GrammarNihongo")]
    public partial class GrammarNihongo
    {
        [Key]
        public int GrammarID { get; set; }

        public string Grammar { get; set; }

        public int? 第課ID { get; set; }

        [StringLength(250)]
        public string GrammarTitle { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}