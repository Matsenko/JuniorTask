using JuniorTest.Shared.Entity;

namespace JuniorTest.Shared.Services
{
    public interface IMaterialService
    {
        Task<List<Material>> GetAllMaterials();
        Task<Material> AddMaterial(Material material);
        Task<Material>  GetMaterialById(int id);
        Task<Material> EditMaterial(int id, Material material);
        Task<bool> DeleteMaterial(int id);
        Task<List<Material>> SearchMaterialsByName(string name);
    }
}
