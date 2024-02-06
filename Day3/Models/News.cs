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
    public class News
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        [ForeignKey("author")]
        public int? AuthorId { get; set; }
        [MinLength(50)]
        public string Bref { get; set; }
        [Column(TypeName = "time")]
        public TimeSpan Time {  get; set; }
        [Column(TypeName ="date")]
        public DateTime Date { get; set; }
        [ForeignKey("catalog")]
        public int? Cat_Id {  get; set; }
        public virtual Catalog catalog { get; set; }
        public virtual Author author { get; set; }

    }
}
