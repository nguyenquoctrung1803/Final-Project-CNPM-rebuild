using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{

    public class CartItem
    {
        public LinhKien _shopping_product { get; set; }
        public int _shopping_quantity { get; set; }
    }
    // Gio Hang
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(LinhKien _pro, int _quantity = 1)
        {
            var item = items.FirstOrDefault(s => s._shopping_product.MaLK == _pro.MaLK);
            if (item == null)
            {
                items.Add(new CartItem
                {
                    _shopping_product = _pro,
                    _shopping_quantity = _quantity
                });                             
            }
            else
            {
                item._shopping_quantity += _quantity;
            }
        }
        public void Update_Quantity_Shopping(String id, int _quantity)
        {
            var item = items.Find(s => s._shopping_product.MaLK == id);
            if (item != null)
            {
                item._shopping_quantity = _quantity;
            }
        }
        public double ToTal_Money()
        {
            var total = items.Sum(s=>s._shopping_product.DonGia * s._shopping_quantity);
            return (double) total;
        }
        public void Remove_CartItem(String id)
        {
            items.RemoveAll(s => s._shopping_product.MaLK == id);
        }
        public int Total_Quantity()
        {
            return items.Sum(s => s._shopping_quantity);
        }
        public void ClearCart()
        {
            items.Clear();
        }
    }
}