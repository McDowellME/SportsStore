using Microsoft.AspNetCore.Mvc;
using ClothingStore.Models;

namespace ClothingStore.Controllers
{
    public class OrderController :Controller
    {
        public ViewResult Checkout() => View(new Order());
    }
}
