using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommWebApp.Models
{
    public class OrderItem : BaseModel
    {
        public int OrderID { get; set; }

        [ForeignKey("OrderID")]
        public Order? Order { get; set; } //= null!;//annotate a property directly as non-nullable. It will give a warning if user tries to set the Property as null
        
        public int ProductID { get; set; }

        [Required]
        [ForeignKey("ProductID")]
        public Product Product { get; set; } //= null!;//annotate a property directly as non-nullable. It will give a warning if user tries to set the Property as null

        [Required(ErrorMessage = "Quantity cannot be empty.")]
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantity)
        {
            Quantity = quantity;
            AddedAt = DateTime.Now;
        }
        public OrderItem(int quantity, Product product)
        {
            Product = product;
            Quantity = quantity;
            AddedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return $"OrderItem Id: {Id}\nQuantity: {Quantity}\nAdded At: {AddedAt}\n\n{Product}\n";
        }
    }
}
