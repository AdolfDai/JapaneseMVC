namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 練習C
    {
        public int 練習CID { get; set; }

        [StringLength(50)]
        public string 練習CAudio { get; set; }

        [StringLength(50)]
        public string 練習Cの写真 { get; set; }

        public string 練習Cの本 { get; set; }

        public string ベトナム語 { get; set; }

        public string 練習C1Ans { get; set; }

        public string 練習C1AnsVNI { get; set; }

        public string 練習C2Ans { get; set; }

        public string 練習C2AnsVNI { get; set; }

        public string 練習C3Ans { get; set; }

        public string 練習C3AnsVNI { get; set; }

        public int? 第課ID { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
