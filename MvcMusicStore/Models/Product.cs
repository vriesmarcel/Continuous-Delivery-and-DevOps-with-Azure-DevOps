using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }

        [DisplayName("Genre")]
        public int CategoryId { get; set; }

        [DisplayName("Artist")]
        public int ManufacturerId { get; set; }

        [Required(ErrorMessage = "An product name is required")]
        [StringLength(160)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 100.00,
            ErrorMessage = "Price must be between 0.01 and 100.00")]
        public decimal Price { get; set; }

        [DisplayName("Album Art URL")]
        [StringLength(1024)]
        public string ProductArtUrl { get; set; }

        public virtual ProductCategory Category{ get; set; }
        public virtual Manufacturer Manufactorer { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }
    }
}