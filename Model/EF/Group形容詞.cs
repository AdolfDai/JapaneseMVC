namespace Model.EF
{
    using System.ComponentModel.DataAnnotations;

    public partial class Group形容詞
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Group形容詞Name { get; set; }

        public virtual 形容詞 形容詞 { get; set; }
    }
}