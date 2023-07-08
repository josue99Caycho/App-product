using Microsoft.AspNetCore.Mvc;
using ProductsApplication.Model.Request;
using ProductsApplication.Model.Response;
using System.Runtime.Serialization;

namespace ProductsApplication.Controllers
{
    [ApiController]
    [Route("api/product")]
    public class ProductController : ControllerBase
    {

        // Obtener todos los productos
        [HttpGet(template: "/api/products")]
        public async Task<ProductResponse> GetAllProducts() 
        {
            try {
                // Llamar a todos los productos al helper
                return new ProductResponse ();
            }
            catch (Exception err) {
                // Manejar los errores de excepcion
                throw err;
            }
        }

        // Obtener producto por ID
        [HttpGet(template: "id")]
        public async Task<ProductResponse> GetProductById([FromQuery] string id)
        {
            try
            {
                // Llamar a todos los productos al helper
                return new ProductResponse();
            }
            catch (Exception err)
            {
                // Manejar los errores de excepcion
                throw err;
            }
        }

        // Obtener producto por UserId
        [HttpGet(template: "userId")]
        public async Task<ProductResponse> GetProductByUserId([FromQuery] string userId)
        {
            try
            {
                // Llamar a todos los productos al helper
                return new ProductResponse();
            }
            catch (Exception err)
            {
                // Manejar los errores de excepcion
                throw err;
            }
        }

        // Crear producto
        [HttpPost]
        public async Task<string> CreateProduct([FromBody] ProductRequest product)
        {
            return "";
        }

        // Actualizar producto
        [HttpPatch(template: "id")]
        public async Task<string> UpdateProduct([FromBody] ProductRequest product)
        {
            try
            {
                // Llamar a todos los productos al helper
                return "";
            }
            catch (Exception err)
            {
                // Manejar los errores de excepcion
                throw err;
            }
        }

        // Eliminar producto
        [HttpDelete(template: "id")]
        public async Task<string> DeleteProduct([FromQuery] string id) 
        {
            try
            {
                // Llamar a todos los productos al helper
                return "";
            }
            catch (Exception err)
            {
                // Manejar los errores de excepcion
                throw err;
            }
        }
    }
}