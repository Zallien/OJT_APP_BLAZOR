using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OJT_App.Model
{
    public class ProductModel
    {

        public Guid Id { get; set; }
        public string Productname { get; set; }
        public decimal price { get; set; }
        public int Quantity { get; set; }
 = 0;   public bool IsActive { get; set; }
        public DateTime Created { get; set; }


    }
}
