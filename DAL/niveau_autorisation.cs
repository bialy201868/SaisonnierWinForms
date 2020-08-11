namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.niveau_autorisation")]
    public partial class niveau_autorisation
    {
        [Key]
        public int CODE_AUTOR { get; set; }

        [Required]
        [StringLength(50)]
        public string LIBELLE_AUTOR { get; set; }
    }
}
