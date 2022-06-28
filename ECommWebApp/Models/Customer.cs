using ECommWebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommWebApp.Models
{
    [Index(nameof(Cnic), IsUnique = true)]
    public class Customer : BaseModel
    {
        [Required(ErrorMessage = "Name cannot be empty.")]
        public string Name { get; set; }
        public string? Address { get; set; }

        [Required(ErrorMessage = "CNIC cannot be empty.")]
        public long Cnic { get; set; }

        [Required(ErrorMessage = "Age cannot be empty.")]
        public int Age { get; set; }

        //public int OrderId { get; set; }//optional
        public List<Order>? Orders { get; set; } //= null;

        //public static int CustomerCount { get; set; } = 0;

        public Customer(string name, long cnic, string address=null!, int age = -1)
        {
            Name = name;
            Address = address;
            Cnic = cnic;
            Age = age;
            Orders = new List<Order>();
            //CustomerCount++;
        }
        public override string ToString()
        {
            return $"Customer Name: {Name}\nCustomer Address: {Address}\nCustomer CNIC: {Cnic}\nCustomer Age: {Age}\n";
        }

        
        /*~Customer()
        {
            Console.WriteLine($"yaya{CustomerCount}");
            --CustomerCount;
        }*/
    }
}
