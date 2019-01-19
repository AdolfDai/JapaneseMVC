namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrammarNihongo")]
    public partial class GrammarNihongo
    {
        [Key]
        public int GrammarID { get; set; }

        public string Grammar { get; set; }

        public int? 第課ID { get; set; }

        public string GrammarTitle { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
