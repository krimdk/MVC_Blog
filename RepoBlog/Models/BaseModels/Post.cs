using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RepoBlog.Models.BaseModels
{
    public class Post
    {
        public int ID { get; set; }
        [Required]
        public string Overskrift { get; set; }
        [Required]
        public string Tekst { get; set; }
        [Required]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime Dato { get; set; }
        [Required]
        public string Forfatter { get; set; }
    }
}
