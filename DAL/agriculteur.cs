namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.agriculteur")]
    public partial class agriculteur
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public agriculteur()
        {
            propositions = new HashSet<proposition>();
            avantages = new HashSet<avantage>();
        }
        [Key]
        [DisplayName("Code")]
        public int CODE_AGRI { get; set; }
        [Browsable(false)]
        public int ID_LOGIN { get; set; }
        [Browsable(false)]
        public int CODE_REGION { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Nom")]
        public string NOM_AGRI { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Prénom")]
        public string PRENOM_AGRI { get; set; }
        [Browsable(false)]
        public float? NOTE_AGRI { get; set; }
        [DisplayName("Description")]
        public string PROFIL_TEXTE { get; set; }
        [Browsable(false)]
        [StringLength(50)]
        public string PROFIL_PHOTO { get; set; }
        [DisplayName("Email")]
        [Required]
        [StringLength(50)]
        public string MAIL_AGRI { get; set; }
        [DisplayName("Téléphone")]
        [Required]
        [StringLength(25)]
        public string TEL_AGRI { get; set; }
        [Browsable(false)]
        public virtual login login { get; set; }
        [Browsable(false)]
        public virtual region region { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proposition> propositions { get; set; }
        [Browsable(false)]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<avantage> avantages { get; set; }
    }
}
