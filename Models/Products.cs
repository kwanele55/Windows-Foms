using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDONT2030.Models
{
    public class Products
    {
        public int productId;
        public string productName="";
        public int supplierId;
        public int categoryId;
        public decimal unitPrice;
        public bool discontinued;
    }
}
