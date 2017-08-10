using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Flickr_Clone.Models
{
    [Table("Images")]
    public class Image
    {
        public Image()
        {
        }

        [Key]
        public int ImageId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public string UserId { get; internal set; }
    }
}
