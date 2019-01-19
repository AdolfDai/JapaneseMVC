namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 文型
    {
        public int 文型ID { get; set; }

        public string 文型の本 { get; set; }

        public string ベトナム語 { get; set; }

        public int 第課ID { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
