using System.ComponentModel.DataAnnotations;
namespace firstWebApi.Entity
{
    public record Items
    {
        [Key]
        public int studentId { get; init; }

        public String name { get; init; }

        public String address { get; init; }
    }
}