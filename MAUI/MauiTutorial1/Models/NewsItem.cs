using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTutorial1.Models
{
    public record NewsItem
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Published { get; set; }
        public string Image { get; set; }
    }
}
