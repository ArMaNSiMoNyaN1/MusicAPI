using Domain.Entities;

namespace Application.Services.Interfaces;

public interface ICategoriesService
{
    Task<List<Categories>> GetAll();
    Task<Categories?> GEtById(int id);
    Task<Categories> Add(Categories category);
    Task<Categories?> Update(Categories updateCategories);
    Task<Categories> Delete(int id);
}