using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Flickr_Clone.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<Image> Images { get; set; }
        public ApplicationUser()
        {
            Images = new List<Image>();
        }
    }
}
