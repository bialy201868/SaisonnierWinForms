namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.region")]
    public partial class region
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public region()
        {
            agriculteurs = new HashSet<agriculteur>();
        }

        [Key]
        [DisplayName("Code")]
        public int CODE_REGION { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Region")]
        public string NOM_REGION { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agriculteur> agriculteurs { get; set; }
    }
}
