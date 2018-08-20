namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("漢字 - Table")]
    public partial class 漢字___Table
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string 漢字 { get; set; }

        [StringLength(50)]
        public string 音漢字 { get; set; }

        public int? 第課ID { get; set; }

        [StringLength(50)]
        public string おんよみ { get; set; }

        [StringLength(50)]
        public string くんよみ { get; set; }

        [StringLength(50)]
        public string 漢字Image { get; set; }

        [StringLength(50)]
        public string 漢字Audio { get; set; }

        public string 例1 { get; set; }

        public string 例2 { get; set; }

        public string Description { get; set; }

        public int? LineOfNumber { get; set; }

        public virtual 第課_Table 第課_Table { get; set; }
    }
}