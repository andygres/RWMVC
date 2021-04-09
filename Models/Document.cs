using System.ComponentModel.DataAnnotations;

namespace RWMVC.Models
{
    public class Document
    {
        [Required]
        public string FileNumber { get; set; }
        [Required]
        public byte[] File { get; set; }
        public string DocumentType { get; set; }
        public string Description { get; set; }
    }

    
}
