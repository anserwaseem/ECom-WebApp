using ECommWebApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommWebApp.Models
{
    public class Order : BaseModel
    {
        public int CustomerID { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; } //= null!;//annotate a property directly as non-nullable. It will give a warning if user tries to set the Property as null
        public DateTime OrderedOn { get; set; }

        [Required]
        public int Total { get; set; } = 0;

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public bool IsDelivered { get; set; }

        [Required]
        public bool IsCancelled { get; set; }
        public List<OrderItem> OrderItems { get; private set; }

        public Order()
        {
            OrderedOn = DateTime.Now;
            OrderItems = new List<OrderItem>();
        }
        public Order(Customer customer)
        {
            Customer = customer;
            OrderedOn = DateTime.Now;
            IsActive = true;
            IsDelivered = false;
            IsCancelled = false;
            OrderItems = new List<OrderItem>();
        }
        public override string ToString()
        {
            return $"Order Id: {Id}\nTotal: {Total}\nActive: {IsActive}\nDelivered: {IsDelivered}\nCancelled: {IsCancelled}\n\n{string.Join("", OrderItems)}";
        }

        public Order AddOrderItem(OrderItem item)
        {
            int PreDiscountPrice = item.Product.Price * item.Quantity;
            Total += PreDiscountPrice - (PreDiscountPrice * item.Product.Discount / 100);
            try
            {
                OrderItems.Add(item);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return this;
        }
    }
}
