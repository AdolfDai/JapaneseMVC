namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class 問題の答えTable
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public string 問題の答え { get; set; }

        public int? 問題Id { get; set; }

        public string ベトナム語 { get; set; }

        public virtual 問題 問題 { get; set; }
    }
}
