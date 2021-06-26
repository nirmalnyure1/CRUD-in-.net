using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Ecommerce.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Name")]
        public string Name { get; set; }

        [Required]
        [Range(1,int.MaxValue,ErrorMessage ="Display order for category must be greater then 0")]
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }

    }
}
