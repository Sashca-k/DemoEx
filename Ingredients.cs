namespace Sashca
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ingredients
    {
        [Key]
        [StringLength(50)]
        public string Articul { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string EdIzm { get; set; }

        public int Quantity { get; set; }

        [StringLength(50)]
        public string Postavshik { get; set; }

        public byte[] Image { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public decimal Price { get; set; }

        [StringLength(50)]
        public string GOST { get; set; }

        [StringLength(50)]
        public string Fasovka { get; set; }

        [StringLength(50)]
        public string Haracteristika { get; set; }

        [StringLength(50)]
        public string Artikula { get; set; }

        public int? Nomer { get; set; }

        public virtual Izdelie Izdelie { get; set; }

        public virtual Ukrashenia Ukrashenia { get; set; }
    }
}
