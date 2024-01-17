using System.ComponentModel.DataAnnotations;

namespace MaximProject.Areas.Manage.ViewModels
{
    public class ServicesCreateVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public IFormFile? Image { get; set; }
    }
}
