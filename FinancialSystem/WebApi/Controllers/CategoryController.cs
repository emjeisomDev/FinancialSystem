using Domain.Interfaces.ICategory;
using Domain.Interfaces.InterfaceServices;
using Entities.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryInterface _CategoryInterface;
        private readonly ICategoryService _ICategoryService;

        public CategoryController(
            CategoryInterface CategoryInterface, 
            ICategoryService ICategoryService)
        {
            _CategoryInterface = CategoryInterface;
            _ICategoryService = ICategoryService;
        }

        [HttpGet("/api/ListUserCategory")]
        [Produces("application/json")]
        public async Task<object> ListUserCategory(string userEmail) 
            => await _CategoryInterface.ListUserCategory(userEmail);

        [HttpGet("/api/GetCategoryById")]
        [Produces("application/json")]
        public async Task<object> GetCategoryById(int id)
        {
            return await _CategoryInterface.GetEntityById(id);
        }

        [HttpPost("/api/AddCategory")]
        [Produces("application/json")]
        public async Task<object> AddCategory(Category category)
        {
            await _ICategoryService.AddCategory(category);
            return category;
        }

        [HttpPut("/api/UpdateCategory")]
        [Produces("application/json")]
        public async Task<object> UpdateCategory(Category category)
        {
            await _ICategoryService.UpdateCategory(category);
            return category;
        }

        [HttpDelete("/api/DeleteCategory")]
        [Produces("application/json")]
        public async Task<object> DeleteCategory(int id)
        {
            try
            {
                var category = await _CategoryInterface.GetEntityById(id);
                await _CategoryInterface.Delete(category);
            }
            catch (Exception)
            {
                return false;
            }

            return true;

        }





    }
}
