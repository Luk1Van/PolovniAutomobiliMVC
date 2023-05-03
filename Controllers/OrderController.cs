using Microsoft.AspNetCore.Mvc;
using PolovniAutomobiliMVC.Models;
using PolovniAutomobiliMVC.ViewModels;

namespace PolovniAutomobiliMVC.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, ShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]        //must have for this checkout becaiuse we wanna send this data to db
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                // ako nema artikala u korpi, dodaje se greska, pri cemu ce
                // modelstate automatski postati nevalidan
                ModelState.AddModelError("", "Your cart is empty :(");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }

            return View(order); //if user makes mistake and doesnt fill one line data in other lines would be saved
        }

        public IActionResult CheckoutComplete()
        {
            CheckoutCompleteViewModel message = new CheckoutCompleteViewModel()
            {
                Message = "Your order is on your way!"
            };
            return View(message);
        }
    }
}
