using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        [StringLength(50)]
        public String CategoryName { get; set; }
        [StringLength(200)]
        public String CategoryDescription { get; set; }
        //sistemden silmek yerine çünkü hiyerarşik düzende 
        //content de gider aktiflik durumu değiştirilip,erişim kaldırılıyor
        public bool CategoryStatus { get; set; }

        public ICollection<Heading> Headings { get; set; }
    }
}
