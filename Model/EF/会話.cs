namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 会話
    {
        public int 会話ID { get; set; }

        public string 会話の本 { get; set; }

        public int? 第課ID { get; set; }

        [StringLength(50)]
        public string 会話の写真 { get; set; }

        [StringLength(100)]
        public string 会話Audio { get; set; }

        [StringLength(50)]
        public string 会話Video { get; set; }

        public string ベトナム語 { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
