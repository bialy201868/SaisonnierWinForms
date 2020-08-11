namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.login")]
    public partial class login
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public login()
        {
            agriculteurs = new HashSet<agriculteur>();
        }

        [Key]
        public int ID_LOGIN { get; set; }

        public int CODE_AUTOR { get; set; }

        [Column("LOGIN")]
        [Required]
        [StringLength(50)]
        public string LOGIN1 { get; set; }

        [Required]
        [StringLength(50)]
        public string MOT_DE_PASSE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<agriculteur> agriculteurs { get; set; }
    }
}
