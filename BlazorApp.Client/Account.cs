using System.ComponentModel.DataAnnotations;

namespace BlazorApp.Client
{
    public class Account
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
