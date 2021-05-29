using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    {
        [Key]
        public int ContentID { get; set; }

        //Content text
        [StringLength(500)]
        public String ContentValue { get; set; }

        public DateTime ContentDate { get; set; }

        //content writer
        public int? WriterID { get; set; }
        public virtual Writer Writer { get; set; }

        //content heading
        public int HeadingID { get; set; }

        public bool ContentStatus { get; set; }
        public virtual Heading Heading { get; set; }
    }
}
