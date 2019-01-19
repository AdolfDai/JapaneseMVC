namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class N5動詞
    {
        public int N5動詞ID { get; set; }

        [StringLength(50)]
        public string ます形 { get; set; }

        [StringLength(50)]
        public string ベトナム語 { get; set; }

        [StringLength(50)]
        public string 辞書形 { get; set; }

        [StringLength(50)]
        public string ません形 { get; set; }

        [StringLength(50)]
        public string ない形 { get; set; }

        [StringLength(50)]
        public string ました形 { get; set; }

        [StringLength(50)]
        public string た形 { get; set; }

        [StringLength(50)]
        public string ませんでした形 { get; set; }

        [StringLength(50)]
        public string なかった形 { get; set; }

        [StringLength(50)]
        public string て形 { get; set; }

        public int? グループID { get; set; }

        [StringLength(50)]
        public string 漢字 { get; set; }

        public int? GroupNameID { get; set; }

        public virtual Group動詞 Group動詞 { get; set; }

        public virtual グループ グループ { get; set; }
    }
}
