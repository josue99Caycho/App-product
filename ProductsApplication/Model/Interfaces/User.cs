using ProductsApplication.Model.Request;
using ProductsApplication.Model.Response;

namespace ProductsApplication.Model.Interfaces
{
    public interface User
    {
        Task<UserResponse> GetAllUsers();
        Task<UserResponse> GetUserById(string userId);
        Task<UserResponse> CreatetUser(UserRequest request);
        Task<UserResponse> UpdatetUser(UserRequest request);
        Task<UserResponse> DeleteUser(string userId);
    }
}
