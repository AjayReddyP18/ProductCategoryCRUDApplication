namespace ProductCategoryCRUDApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        public int ProductId { get; set; }

        [StringLength(50)]
        public string ProductName { get; set; }

        public int? CategoryId { get; set; }

        [StringLength(50)]
        public string CategoryName { get; set; }
    }
}
