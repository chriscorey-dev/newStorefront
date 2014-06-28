using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace newStorefront.Models
{
    [MetadataType(typeof(ProductMetaData))]
    public partial class Product
    {
    }

    public class ProductMetaData
    {
        [Display(Name = "Name")]
        public string Name;

        [Display(Name = "Price")]
        public string Price;

        [Display(Name = "Quantity")]
        public string Quantity;

        [Display(Name = "Description (Optional)")]
        public string Description;

        [Display(Name = "Parent Category")]
        public string CategoryID;

        [Display(Name = "Supplier")]
        public string SupplierID;
    }

    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category
    {
    }

    public class CategoryMetaData
    {
        [Display(Name = "Category Name")]
        public string Name;

        [Display(Name = "Parent Category")]
        public string ParentID;
    }
}