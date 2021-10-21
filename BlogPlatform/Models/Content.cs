using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Models
{
    public class Content
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Body { get; set; }

        //add automatic date and time
        public DateTime Now { get; set; }
        



        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
