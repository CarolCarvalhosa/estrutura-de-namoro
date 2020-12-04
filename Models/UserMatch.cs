namespace EstruturasDeNamoro
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    [Table("UserMatch")]
    public partial class UserMatch
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public int User2Id { get; set; }

        public User User2 { get; set; }

        [Column(TypeName = "date")]
        public DateTime Created_date { get; set; }
        
        [Column(TypeName = "date")]
        public DateTime? Updated_date { get; set; }

        public void FillData()
        {
            EntityModel entities = new EntityModel();

            // Combinando Metodos de extensao e LINQ
            this.User = entities.User.First(x => x.Id == this.UserId);
            this.User2 = entities.User.First(x => x.Id == this.User2Id);

        }
    }
}
