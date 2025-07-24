using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OJT_App.Model;

namespace OJT_App.Service
{
    public interface iProduct
    {
        Task<List<ProductModel>> GetProducts();
        Task<Boolean> AddProdctItem(ProductInsert prod);
        Task<Boolean> DeleteProductItem(Guid Prod);


    }
}
