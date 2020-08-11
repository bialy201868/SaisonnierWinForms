namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.avantage")]
    public partial class avantage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public avantage()
        {
            agriculteurs = new HashSet<agriculteur>();
        }

        [Key]
        public int CODE_AVANTAGE { get; set; }

        [Required]
        [StringLength(50)]
        public string LIBELLE_AVANTAGE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agriculteur> agriculteurs { get; set; }
    }
}
