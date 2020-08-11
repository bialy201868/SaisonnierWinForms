namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.statut_candidat")]
    public partial class statut_candidat
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public statut_candidat()
        {
            est_candidat = new HashSet<est_candidat>();
        }

        [Key]
        public int CODE_STATUT { get; set; }

        [Required]
        [StringLength(50)]
        public string LIBELLE_STATUT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<est_candidat> est_candidat { get; set; }
    }
}
