namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.service")]
    public partial class service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public service()
        {
            propositions = new HashSet<proposition>();
        }

        [Key]
        public int CODE_SERVICE { get; set; }

        [Required]
        [StringLength(100)]
        public string LIBELLE_SERVICE_COURT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<proposition> propositions { get; set; }
    }
}
