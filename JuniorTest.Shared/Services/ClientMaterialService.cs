using JuniorTest.Shared.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace JuniorTest.Shared.Services
{
    public class ClientMaterialService:IMaterialService
    {
        private readonly HttpClient _httpClient;
        public ClientMaterialService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<List<Material>> GetAllMaterials()
        {
            return await _httpClient.GetFromJsonAsync<List<Material>>("api/Material");
        }
        public async Task<Material> AddMaterial(Material material)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Material", material);
            return await result.Content.ReadFromJsonAsync<Material>();
        }
        public async Task<Material> GetMaterialById(int id)
        {
            return await _httpClient.GetFromJsonAsync<Material>($"api/Material/{id}");
        }
        public async Task<bool> DeleteMaterial(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/Material/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }
        public async Task<Material> EditMaterial(int id, Material material)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/Material/{id}", material);
            return await result.Content.ReadFromJsonAsync<Material>();
        }   
        public async Task<List<Material>> SearchMaterialsByName(string name)
        {
            return await _httpClient.GetFromJsonAsync<List<Material>>($"api/Material/Search/{name}");
        }
        
    }
}

