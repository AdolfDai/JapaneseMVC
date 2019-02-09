namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 言葉Table
    {
        [Key]
        public int 言葉ID { get; set; }

        [StringLength(50)]
        public string ひらがな { get; set; }

        [StringLength(50)]
        public string 漢字 { get; set; }

        [StringLength(50)]
        public string 音漢字 { get; set; }

        public string ベトナム語 { get; set; }

        public int? 第課ID { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
