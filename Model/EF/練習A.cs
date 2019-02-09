namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 練習A
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string 練習Aの名 { get; set; }

        public string 練習Aの本 { get; set; }

        public string 練習Aの答え { get; set; }

        public int? 第課ID { get; set; }

        public string ベトナム語 { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
