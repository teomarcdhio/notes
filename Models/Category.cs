using System.ComponentModel.DataAnnotations;

namespace Notes.Models
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }

    }

}