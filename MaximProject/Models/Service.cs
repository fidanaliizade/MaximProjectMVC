using MaximProject.Models.BaseModel;

namespace MaximProject.Models
{
    public class Service:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string? ImgUrl { get; set; }
    }
}
