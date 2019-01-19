namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 漢字
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string 漢字の本 { get; set; }

        [StringLength(50)]
        public string 音漢字 { get; set; }

        public int? 第課ID { get; set; }

        [StringLength(50)]
        public string おんよみ { get; set; }

        [StringLength(50)]
        public string くんよみ { get; set; }

        [StringLength(50)]
        public string 漢字の写真 { get; set; }

        [StringLength(50)]
        public string 漢字Audio { get; set; }

        public string 例1 { get; set; }

        public string 例2 { get; set; }

        public string Description { get; set; }

        public int? LineOfNumber { get; set; }

        public virtual 第課 第課 { get; set; }
    }
}
