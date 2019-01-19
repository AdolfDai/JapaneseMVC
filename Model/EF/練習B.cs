namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 練習B
    {
        public int 練習BID { get; set; }

        [StringLength(50)]
        public string 練習Bの写真 { get; set; }

        public string 練習Bの本 { get; set; }

        public string 練習BAnswer { get; set; }

        public string 練習BVietnamese { get; set; }

        public int 第課ID { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
