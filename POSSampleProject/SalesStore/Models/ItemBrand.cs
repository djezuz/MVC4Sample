using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SalesStore.Entities
{
    [Table("dim.ItemBrand", Schema = "dbo")]
    public class ItemBrand
    {
        [Key]
        public virtual int itemBrandCode { get; set; }
        public virtual string brandName { get; set; }
        public virtual string arabicName { get; set; }
        public virtual bool isActive { get; set; }
    }

}