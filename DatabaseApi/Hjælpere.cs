namespace DatabaseApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Hjælpere
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Navn { get; set; }

        [Required]
        [StringLength(11)]
        public string TelefonNummer { get; set; }

        [Required]
        [StringLength(255)]
        public string Kodeord { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        public bool IsAdmin { get; set; }
    }
}
