namespace Sashca
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Izdelie")]
    public partial class Izdelie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Izdelie()
        {
            Ingredients = new HashSet<Ingredients>();
            PrimerZakaz = new HashSet<PrimerZakaz>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Nomer { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Column("Izdelie")]
        [Required]
        [StringLength(50)]
        public string Izdelie1 { get; set; }

        [Required]
        [StringLength(50)]
        public string ZakazLogin { get; set; }

        [StringLength(50)]
        public string MenegerLogin { get; set; }

        public decimal? Cost { get; set; }

        [Column(TypeName = "date")]
        public DateTime? PlanEndDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ingredients> Ingredients { get; set; }

        public virtual Users Users { get; set; }

        public virtual Users Users1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrimerZakaz> PrimerZakaz { get; set; }
    }
}
