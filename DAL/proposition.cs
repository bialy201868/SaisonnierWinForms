namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.proposition")]
    public partial class proposition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public proposition()
        {
            est_candidat = new HashSet<est_candidat>();
            services = new HashSet<service>();
        }

        [Key]
        [DisplayName("Code")]
        public int CODE_PROPOS { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Date debut")]
        public DateTime DATE_FIN_PROPO { get; set; }
        [Browsable(false)]
        public int CODE_AGRI { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Date fin")]
        public DateTime DATE_DEBUT_PROPO { get; set; }

        [DisplayName("Places total")]
        public int NB_PLACES { get; set; }
        [DisplayName("Heures/jour")]
        public float NB_HEURES_JOUR { get; set; }
        [DisplayName("Jours/semaine")]
        public float NB_JOURS_SEMAINE { get; set; }
        [DisplayName("Salaire")]
        public float SALAIRE_BRUT_HORAIRE { get; set; }
        [Browsable(false)]

        public short PUBLIEE { get; set; }
        [Browsable(false)]
        public virtual agriculteur agriculteur { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<est_candidat> est_candidat { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<service> services { get; set; }
    }
}
