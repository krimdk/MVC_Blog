using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoBlog.Models.BaseModels
{
    public class Post
    {
        private int ID { get; set; }
        private string Overskrift { get; set; }
        private string Tekst { get; set; }
        private DateTime Dato { get; set; }
        private string Forfatter { get; set; }
    }
}
