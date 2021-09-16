using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PropertyManager.DataModel.Model;
using PropertyManager.Repo;
using PropertyManager.Repo.Interface;

namespace PropertyManager.Services
{
    public class PropertyService
    {
        private readonly IPropertyRepo _propertyRepo;

        public PropertyService(IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }

        public async Task<IEnumerable<Property>> ViewPropertiesAsync()
        {
            return await _propertyRepo.GetAsync();
        }

        public async Task<Property> ViewPropertyAsync(int id)
        {
            return await _propertyRepo.GetByIdAsync(id);
        }

        public async Task<int> CreatePropertyAsync(Property prop)
        {
            return await _propertyRepo.CreateAsync(prop);
        }

        public async Task UpdatePropertyAsync(Property prop)
        {
            await _propertyRepo.UpdateAsync(prop);
        }

        public async Task DeletePropertyAsync(int id)
        {
            await _propertyRepo.DeleteAsync(id);
        }
    }
}