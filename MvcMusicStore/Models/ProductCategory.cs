using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMusicStore.Models
{
    public class ProductCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Product> Products { get; set; }
    }

    public class AlbumProductCategory : ProductCategory
    {
        public AlbumProductCategory()
        {
            CategoryId = 0;
            Name = "Album";
            Description = "Album Category";
        }
    }
}