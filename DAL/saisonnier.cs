namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.saisonnier")]
    public partial class saisonnier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public saisonnier()
        {
            est_candidat = new HashSet<est_candidat>();
        }

        [Key]
        [DisplayName("Code")]
        public int CODE_SAISONNIER { get; set; }
        [Browsable(false)]
        public int ID_LOGIN { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Nom")]
        public string NOM_SAISON { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Prénom")]
        public string PRENOM_SAISON { get; set; }

        [Column(TypeName = "date")]
        [DisplayName("Date de naissance")]
        public DateTime DATE_NAISSANCE_SAISON { get; set; }

        [Browsable(false)]
        public string SEXE { get; set; }
        [Browsable(false)]
        public float? NOTE_SAISONNIER { get; set; }

        [Required]
        [DisplayName("Description")]
        public string PROFIL_TEXTE_SAISON { get; set; }

        [Browsable(false)]
        public string PROFIL_PHOTO_SAISON { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Email")]
        public string MAIL_SAISONNIER { get; set; }

        [Required]
        [StringLength(25)]
        [DisplayName("Téléphone")]
        public string TEL_SAISONNIER { get; set; }
        [Browsable(false)]

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<est_candidat> est_candidat { get; set; }
    }
}
