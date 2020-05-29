using System;
using System.Collections.Generic;

namespace ProductsAPI.Services
{
    public interface IProductsService
    {
         List<Product> GetProducts();

        Product AddProduct(Product productItem);

        Product UpdateProduct(string id, Product productItem);

        string DeleteProduct(string id);
    }
}
