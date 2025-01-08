using Microsoft.AspNetCore.Mvc;
using  CustomerOrder.Models;
using CustomerOrder.Models.SharedProp;
namespace CustomerOrder.Controllers
{
    public class CustomerController : Controller
    {
        static List<Customer> AllCustomers = new List<Customer>
        {
            new Customer { CustomerId = 1, CustomerName = "Ahmad", Email = "A@OUTLOOK.COM", Phone = 104343400 ,CreationDate=DateTime.Now,IsActive=true,IsDeleted=false},
            new Customer { CustomerId = 2, CustomerName = "Mohammad", Email = "M@OUTLOOKCOM", Phone = 20242200 ,CreationDate=DateTime.Now,IsActive=true,IsDeleted=false},
            new Customer { CustomerId = 3, CustomerName = "Ali", Email = "A@OUTLOOK.COM", Phone = 300342340 ,CreationDate=DateTime.Now,IsActive=true,IsDeleted=false},
            new Customer { CustomerId = 4, CustomerName = "Omar", Email = "O@OUTLOOK.COM", Phone = 404342400,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false },
            new Customer { CustomerId = 5, CustomerName = "Samer", Email = "S@gmail.com", Phone = 50343400,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false },
            new Customer { CustomerId = 6, CustomerName = "Hassan", Email = "h@gmail.com", Phone = 602343400,CreationDate=DateTime.Now,IsActive=false,IsDeleted=false }
        };




        public IActionResult GetAllCustomers()
        {
            return View(AllCustomers);
        }


        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("GetAllCustomers");
            }

            else if (id == 0)
            {
                return RedirectToAction("GetAllCustomers");
            }



            else
            {
                var customer = (from x in AllCustomers where x.CustomerId == id select x).SingleOrDefault();
                if (customer == null)
                {
                    return RedirectToAction("NotFoundCustomer");
                }
                else
                    return View(customer);
            }
        }



        public IActionResult NotFoundCustomer()
        {
            return View();
        }



        [HttpGet] // to make the method post

        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]

        public IActionResult CreateCustomer(Customer cus)
        {


            AllCustomers.Add(cus);
            return RedirectToAction(nameof(GetAllCustomers));
        }
      



        
      
        public IActionResult ActiveCus()
        {
            var yes = (from x in AllCustomers where x.IsActive == true select x);
            return View(yes);
        }




        public IActionResult NonActiveCus()
        {
            var non = (from x in AllCustomers where x.IsActive == false select x);
            return View(non);
        }




    }
}


  