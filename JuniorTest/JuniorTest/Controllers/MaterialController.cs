using JuniorTest.Shared.Entity;
using JuniorTest.Shared.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JuniorTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaterialController : ControllerBase
    {
        private readonly IMaterialService _materialService;
        public MaterialController(IMaterialService materialService)
        {
            _materialService = materialService;
        }
        [HttpPost]
        public async Task<ActionResult<Material>> AddMaterials(Material material)
        {
            var addedMaterial = await _materialService.AddMaterial(material);
            return Ok(addedMaterial);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Material>> GetMaterialById(int id)
        {
            var material = await _materialService.GetMaterialById(id);
            return Ok(material);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Material>> EditMaterial(int id, Material material)
        {
            var editedMaterial = await _materialService.EditMaterial(id, material);
            return Ok(editedMaterial);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteMaterial(int id)
        {
            var result = await _materialService.DeleteMaterial(id);
            return Ok(result);
        }
        [HttpGet]
        public async Task<ActionResult<List<Material>>> SearchMaterialsByName([FromQuery] string name)
        {
            var materials = await _materialService.SearchMaterialsByName(name);
            return Ok(materials);
        }
    }
}
