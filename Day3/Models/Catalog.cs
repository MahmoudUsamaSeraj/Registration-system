#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Day3.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [MinLength(50)]
        public string Description { get; set; }

        public virtual List<News> news { get; set; }=new List<News>();
    }
}
