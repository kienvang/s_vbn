using System;

/// <summary>
/// Summary description for CartEntity
/// </summary>
namespace Modules.Cart
{
    public class CartItem
    {
        public const string _SupplierId = "SupplierId";
        public const string _ProductId = "ProductId";
        public const string _ProductName = "ProductName";
        public const string _ProductCode = "ProductCode";
        public const string _Price = "Price";
        public const string _Total = "Total";
        public const string _ProductParentId = "ProductParentId";

        public Guid SupplierId { get; set; }
        public Guid ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductCode { get; set; }
        public decimal Price { get; set; }
        public int Total { get; set; }
        public Guid ProductParentId { get; set; }
    }
}