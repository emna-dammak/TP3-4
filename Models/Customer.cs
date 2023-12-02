using System.ComponentModel.DataAnnotations.Schema;

namespace TP3.Models
{
    public class Customer
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }

        [ForeignKey(nameof(Membershiptype))]

        public Guid MembershiptypesId { get; set; }

        public virtual Membershiptype? Membershiptypes { get; set; }

        public virtual ICollection<Movie>? Movies { get; set; }




    }
}
