using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        PM_BanLinhKienPCEntities _db = new PM_BanLinhKienPCEntities();
        public Cart GetCart()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart==null || Session["Cart"] == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }
            return cart;
        }
        // add item vao gio hang
        public ActionResult AddtoCart(String id)
        {
            var pro = _db.LinhKiens.SingleOrDefault(s => s.MaLK == id);
            if(pro != null)
            {
                GetCart().Add(pro);
            }
            return RedirectToAction("ShowToCart", "ShoppingCart");
        }
        //trang gio hang
        public ActionResult ShowToCart()
        {
            if(Session["Cart"] == null)
            {
                return RedirectToAction("ShowToCart", "ShoppingCart");
            }
            Cart cart = Session["Cart"] as Cart;
            return View(cart);
        }
        public ActionResult Update_Quantity_Cart(FormCollection form)
        {
            Cart cart = Session["Cart"] as Cart;
            String id_pro = form["ID_Product"];
            int quantity = int.Parse(form["Quantity"]);
            cart.Update_Quantity_Shopping(id_pro, quantity);
            return RedirectToAction("ShowToCart", "ShoppingCart");
        }
        public ActionResult RemoveCart(String id)
        {
            Cart cart = Session["Cart"] as Cart;
            cart.Remove_CartItem(id);
            return RedirectToAction("ShowToCart", "ShoppingCart");
        }
        public ActionResult BagCart()
        {
            int _t_item = 0;
            Cart cart = Session["Cart"] as Cart;
            if (cart != null)
            {
                _t_item = cart.Total_Quantity();

            }
            ViewBag.infoCart = _t_item;
            return PartialView("BagCart");
        }
        public ActionResult Shopping_Success ()
        {
            return View();
        }

        // Thanh Toan      
        public ActionResult CheckOut(FormCollection form)
        {
            try
            {
                Cart cart = Session["Cart"] as Cart;
                Order _order = new Order();                            
                _order.OrderDate = DateTime.Now;
                _order.CodeCus = int.Parse(form["CodeCustomer"]);
                _order.Descriptions = form["Address_Delivery"];
                _db.Orders.Add(_order);
                foreach(var item in cart.Items)
                {
                    OrderDetail _other_Detail = new OrderDetail();
                    _other_Detail.IDOrder = _order.IDOrder;
                    _other_Detail.MaLK = item._shopping_product.MaLK;
                    _other_Detail.UnitPriceSale = item._shopping_product.DonGia;
                    _other_Detail.Quantity = item._shopping_quantity;
                    _db.OrderDetails.Add(_other_Detail);
                }
                _db.SaveChanges();
                cart.ClearCart();
                return RedirectToAction("Shopping_Success", "ShoppingCart");
            }
            catch
            {
                return Content("Error Checkout. Vui lòng kiểm tra lại....");
            }
        }
    }
}