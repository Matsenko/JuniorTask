
using JuniorTest.Shared.Data;
using JuniorTest.Shared.Entity;
using Microsoft.EntityFrameworkCore;

namespace JuniorTest.Shared.Services
{
    public class MaterialService:IMaterialService
    {
        private readonly DatabaseContext _context;
        public MaterialService(DatabaseContext context)
        {
            _context = context;
        }
        public async Task<List<Material>> GetAllMaterials()
        {
            var materials = await _context.Materials.ToListAsync();
            return materials;
        }
        public async Task<Material> AddMaterial(Material material)
        {
            _context.Materials.Add(material);
            await _context.SaveChangesAsync();
            return material;
        }
        public async Task<Material> GetMaterialById(int id)
        {
            return await _context.Materials.FindAsync(id);
        }
        public async Task<bool> DeleteMaterial(int id)
        {
            var material = await _context.Materials.FindAsync(id);
            if (material != null)
            {
                _context.Materials.Remove(material);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }   
        public async Task<Material> EditMaterial(int id, Material material)
        {
            var dbMaterial = await _context.Materials.FindAsync(id);
            if(dbMaterial != null)
            {
                dbMaterial.ItemCode = material.ItemCode;
                dbMaterial.ItemType = material.ItemType;
                dbMaterial.HSN = material.HSN;
                dbMaterial.CGST = material.CGST;
                dbMaterial.DisplayName = material.DisplayName;
                dbMaterial.UnitPrice = material.UnitPrice;
                dbMaterial.SGST = material.SGST;
                dbMaterial.IGST = material.IGST;
                dbMaterial.Department = material.Department;
                await  _context.SaveChangesAsync();
                return dbMaterial;
            }   
            throw new Exception("Material not found");
        }
        public async Task<List<Material>> SearchMaterialsByName(string name)
        {
            var materials = await _context.Materials
                .Where(m => m.DisplayName.Contains(name))
                .ToListAsync();

            return materials;
        }
    }
}
