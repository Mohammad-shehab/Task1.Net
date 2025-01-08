
using System.ComponentModel.DataAnnotations;
using CustomerOrder.Models.SharedProp;

namespace CustomerOrder.Models
{
    public class Customer : BaseProp
    {
        
            // prop pk & identity: Id or ClassNameId

            [Display(Name = "ID")]
            public int CustomerId { get; set; }




            [Display(Name = "Name")]
            public string CustomerName { get; set; }



            [Display(Name = "Email")]
            public string Email { get; set; }

            [Display(Name = "Phone")]
            public int Phone { get; set; }


            [Display(Name = "City")]
            public string City { get; set; }


        }
    }

