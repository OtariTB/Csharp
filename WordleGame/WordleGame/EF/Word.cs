namespace WordleGame.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Word
    {
        [Key]
        public int W_Id { get; set; }

        [StringLength(5)]
        public string Words { get; set; }
    }
}
