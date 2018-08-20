namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class 形容詞
    {
        public int Id { get; set; }

        [Column("形容詞")]
        [StringLength(50)]
        public string 形容詞1 { get; set; }

        public int? Group形容詞 { get; set; }

        public int? 第課ID { get; set; }

        public virtual Group形容詞 Group形容詞1 { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}