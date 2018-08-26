namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;

    public partial class かなとはく
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Hiragana { get; set; }

        [StringLength(50)]
        public string ImageHiragana { get; set; }

        [StringLength(50)]
        public string Katakana { get; set; }

        [StringLength(50)]
        public string ImageKatakana { get; set; }

        public int? ColumnWord { get; set; }
    }
}