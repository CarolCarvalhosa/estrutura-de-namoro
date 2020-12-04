namespace EstruturasDeNamoro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(120)]
        public string Name { get; set; }

        [Required]
        [StringLength(120)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Gender { get; set; }

        [StringLength(500)]
        public string PhotoURL { get; set; }

        [Column(TypeName = "date")]
        public DateTime Created_date { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime? Updated_date { get; set; }
    }
}
