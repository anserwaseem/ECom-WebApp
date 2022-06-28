using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommWebApp.Models
{
    public enum Category
    {
        Health,
        Fashion,
        Electronics,
        other,
    }
    public class Product : BaseModel
    {
        //public int OrderItemId { get; set; }
        //public virtual OrderItem? OrderItem { get; set; } //= null; //= null!;//annotate a property directly as non-nullable. It will give a warning if user tries to set the Property as null
        
        [Required(ErrorMessage = "Name cannot be empty.")]
        public string Name { get; set; }
        public string? Description { get; set; }

        [Required(ErrorMessage = "Price cannot be empty.")]
        public int Price { get; set; }

        [Required]
        public int Discount { get; private set; }
        public Product()
        {

        }
        public Product(string name, int price) { Name = name; Price = price; }
        public Product(string name, int price, string description=null!, Category category=Category.other)
        {
            Name = name;
            Description = description;
            Price = price;
            Discount = category switch
            {
                Category.Health => 7,
                Category.Fashion => 10,
                Category.Electronics => 2,
                Category.other or _ => 0,
            };
        }
        public bool SetCategory(Category category)
        {
            try
            {
                switch (category)
                {
                    case Category.Health:
                        Discount = 7;
                        break;
                    case Category.Fashion:
                        Discount = 10;
                        break;
                    case Category.Electronics:
                        Discount = 2;
                        break;
                    default:
                        Discount = 0;
                        break;
                }
                return true;
            }
            catch (Exception e) { Console.WriteLine(e); }
            return false;
        }
        public override string ToString()
        {
            return $"Product Id: {Id}\nName: {Name}\nDescription {Description}\nPrice {Price}\nDiscount: {Discount}\n";
        }
    }
}
