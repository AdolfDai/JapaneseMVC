namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Group形容詞
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Group形容詞Name { get; set; }

        public virtual 形容詞 形容詞 { get; set; }
    }
}
