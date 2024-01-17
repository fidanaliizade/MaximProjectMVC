using System.ComponentModel.DataAnnotations;

namespace MaximProject.Areas.Manage.ViewModels
{
    public class ServicesUpdateVM
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        
        public IFormFile? Image { get; set; }
     
    }
}
