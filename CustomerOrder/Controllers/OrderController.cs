using CustomerOrder.Models;
using Microsoft.AspNetCore.Mvc;

namespace CustomerOrder.Controllers
{
    public class OrderController : Controller
    {
        static List<Order> AllOrders = new List<Order>
        {
            new Order {Amount=221211, CustomerId = 1, OrderName = "Iphone",  OrderId = 13400 ,CreationDate=DateTime.Now,IsActive=true,IsDeleted=false},
            new Order {Amount=212121, CustomerId = 2, OrderName = "Samsung",  OrderId = 22200 ,CreationDate=DateTime.Now,IsActive=true,IsDeleted=false},
            new Order {Amount=21121,CustomerId = 3, OrderName = "PS5",  OrderId = 342340 ,CreationDate=DateTime.Now,IsActive=true,IsDeleted=false},
            new Order {Amount=22211, CustomerId = 4, OrderName = "PS4",  OrderId = 402400,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false },
            new Order {Amount=212, CustomerId = 5, OrderName = "WII",  OrderId = 50300,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false },
            new Order {Amount=212121,CustomerId = 6, OrderName = "XBOX",  OrderId = 60400,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false },
            new Order {Amount=21,CustomerId = 3, OrderName = "PS5",  OrderId = 34221340 ,CreationDate=DateTime.Now,IsActive=true,IsDeleted=false},
            new Order {Amount=22121, CustomerId = 4, OrderName = "PS4",  OrderId = 402121400,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false },
            new Order {Amount=21211, CustomerId = 5, OrderName = "WII",  OrderId = 5032100,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false },
            new Order {Amount=21211,CustomerId = 6, OrderName = "XBOX",  OrderId = 60402120,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false }
        };


        public IActionResult OrderDetails(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("GetAllCustomers", "Customer");
            }

            else if (id == 0)
            {
                return RedirectToAction("GetAllCustomers","Customer");
            }



            else
            {
                var customer = (from x in AllOrders where x.CustomerId == id select x);
                if (customer == null)
                {
                    return RedirectToAction("NotFoundCustomer","Customer");
                }
                else
                    return View(customer);
            }
        }



        public IActionResult NotFoundOrder()
        {
            return View();
        }


        [HttpGet] // to make the method post

        public IActionResult CreateOrder()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateOrder(Order ord)
        {


            AllOrders.Add(ord);
            return RedirectToAction("GetAllCustomers", "Customer");
        }


    }
}
