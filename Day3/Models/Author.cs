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
    public class Author
    {
        
        public int Id { get; set; }
        [StringLength(50)]
        public string Name { get; set; }

        public int? Age {  get; set; }
        [Required]
        [StringLength(50)]
        public string UserName { get; set; }
        [StringLength(50)]
        [Required]
        public string Password { get; set; }
        [Column(TypeName="date")]
        public DateTime JoinDate { get; set; }

        public virtual List<News> news { get; set; } = new List<News>();
    }
}
