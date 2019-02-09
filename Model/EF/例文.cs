namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 例文
    {
        public int 例文ID { get; set; }

        public string 例文の本 { get; set; }

        public int? 第課ID { get; set; }

        public string ベトナム語 { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
