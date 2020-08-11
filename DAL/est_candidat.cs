namespace DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saison.est_candidat")]
    public partial class est_candidat
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE_SAISONNIER { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE_PROPOS { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODE_STATUT { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DATE_CANDIDATURE { get; set; }

        public int? NOTE_AGRI_PROPO { get; set; }

        public int? NOTE_SAISONNIER_PROPO { get; set; }

        public string COMMENTAIRE_SAISONNIER { get; set; }

        public string COMMENTAIRE_AGRI { get; set; }

        public virtual proposition proposition { get; set; }

        public virtual saisonnier saisonnier { get; set; }

        public virtual statut_candidat statut_candidat { get; set; }
    }
}
