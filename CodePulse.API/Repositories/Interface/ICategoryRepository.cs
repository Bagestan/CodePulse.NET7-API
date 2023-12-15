using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Interface
{
    public interface ICategoryRepositor
    {
        Task<Category> CreateAsync(Category category); 

        

    }
}
