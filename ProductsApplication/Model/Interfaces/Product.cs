using ProductsApplication.Model.Request;
using ProductsApplication.Model.Response;

namespace ProductsApplication.Model.Interfaces
{
    public interface IProduct
    {
        Task<ProductResponse> GetAllProducts();
        Task<ProductResponse> GetProductById(string productId);
        Task<string> CreateProduct(ProductRequest request);
        Task<string> UpdateProduct(ProductRequest request);
        Task<string> DeleteProduct(string productId);
    }
}
