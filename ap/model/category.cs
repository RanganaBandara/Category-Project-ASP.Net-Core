using System.ComponentModel.DataAnnotations;

namespace ap.model
{

    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public String name { get; set; }


        [Display(Name = "Display order")]
        [Range(1, 100, ErrorMessage = "invalid range")]

        public int displayorder { get; set; }

    }
}