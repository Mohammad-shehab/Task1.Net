using System.ComponentModel.DataAnnotations;
using CustomerOrder.Models.SharedProp;

namespace CustomerOrder.Models
{
    public class Order : BaseProp
    {


        // prop pk & identity: Id or ClassNameId

        [Display(Name = "Order ID")]
        public int OrderId { get; set; }



        [Display(Name = "Order Name")]
        public string OrderName { get; set; }



        [Display(Name = "Amount")]
        public int Amount { get; set; }

        [Display(Name = "Customer Id")]
        public int CustomerId { get; set; }


    }
}

